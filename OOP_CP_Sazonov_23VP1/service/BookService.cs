using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.service
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IGenreRepository _genreRepository;
        public BookService(IBookRepository repository, IAuthorRepository authorRepository, IGenreRepository genreRepository)
        {
            _bookRepository = repository;
            _authorRepository = authorRepository;
            _genreRepository = genreRepository;
        }

        public List<Book> getAllBooks() {
            return _bookRepository.GetAllBooks();
        }

        public Book? getBookById(long id) {
            return _bookRepository.GetBookById(id);
        }

        public Book? saveBook(string bookName, int yearOfPublishing, string publisher, string ISBN, List<long> authorIds, List<long> genreIds) {
            Book book = new Book.Builder().WithTitle(bookName)
                .WithYearOfPublication(yearOfPublishing)
                .WithPublisher(publisher)
                .WithISBN(ISBN)
                .Build();

            return _bookRepository.SaveBook(book, authorIds, genreIds);
        }

        public void AddAuthors(long bookId, List<long> authorIds)
        {
            var book = _bookRepository.GetBookById(bookId);

            if (book == null)
            {
                throw new ArgumentException($"Book with id {bookId} not found");
            }

            foreach (var authorId in authorIds)
            {
                var author = _authorRepository.GetAuthorById(authorId);
                if (author == null)
                {
                    throw new ArgumentException($"Автор с id {authorId} не найден.");
                }

                _bookRepository.AddAuthorship(book, author);
            }
        }

        public Book? UpdateBook(long bookId, string bookName, int yearOfPublishing, string publisher, string isbn, List<long> authorIds, List<long> genreIds)
        {
            Book? book = _bookRepository.GetBookById(bookId);

            if (book == null) {
                return null;
            }

            book.Title = bookName;
            book.YearOfPublication = yearOfPublishing;
            book.Publisher = publisher;
            book.ISBN = isbn;
            book.Authors.Clear();
            book.Genres.Clear();

            return _bookRepository.UpdateBook(book, authorIds, genreIds);
        }
    }
}
