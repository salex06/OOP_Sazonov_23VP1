using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.model.orm;
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

        public Book? saveBook(string bookName, int yearOfPublishing, string publisher, string ISBN) {
            Book book = new Book.Builder().WithTitle(bookName)
                .WithYearOfPublication(yearOfPublishing)
                .WithPublisher(publisher)
                .WithISBN(ISBN)
                .Build();

            return _bookRepository.SaveBook(book);
        }

        public void AddAuthorsAndGenresToBook(long bookId, List<long> authorIds, List<long> genreIds)
        {
            var book = _bookRepository.GetBookById(bookId) ?? throw new ArgumentException($"Книга с Id '{bookId}' не найдена.");
            List<Author> authors = new List<Author>();
            foreach(int authorId in authorIds){ 
                Author? author = _authorRepository.GetAuthorById(authorId);
                if (author != null) {
                    authors.Add(author);
                }
            }

            List<Genre> genres = new List<Genre>();
            foreach (int genreId in genreIds)
            {
                Genre? genre = _genreRepository.GetGenreById(genreId);
                if (genre != null)
                {
                    genres.Add(genre);
                }
            }

            foreach (var author in authors)
            {
                //book.AddAuthor(author);
                _bookRepository.SaveAuthorship(new Authorship(book, author));
            }

            foreach (var genre in genres)
            {
                //book.AddGenre(genre);
                _bookRepository.SaveBookGenre(new BookGenres(book, genre));
            }

            _bookRepository.UpdateBook(book); 
        }
    }
}
