using OOP_CP_Sazonov_23VP1.forms;
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
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="repository">Репозиторий, взаимодействующий с сущностями типа Book в БД</param>
        /// <param name="authorRepository">Репозиторий, взаимодействующий с сущностями типа Author в БД</param>
        public BookService(IBookRepository repository, IAuthorRepository authorRepository)
        {
            _bookRepository = repository;
            _authorRepository = authorRepository;
        }
        
        /// <summary>
        /// Получить список всех книг из БД в отсортированном и отфильтрованном виде
        /// </summary>
        /// <param name="orderBy_value">поле, по которому производится сортировка</param>
        /// <param name="isAscending">режим сортировки: по возрастанию/по убыванию</param>
        /// <param name="filters">фильтры для книг</param>
        /// <returns>Пара "список книг - общее количество книг в БД (без фильтрации)"</returns>
        public KeyValuePair<List<Book>, int> getAllBooks(string orderBy_value, bool isAscending, dto.BookFilterOptions filters) {
            return _bookRepository.GetAllBooks(orderBy_value, isAscending, filters);
        }

        /// <summary>
        /// Получить книгу по её идентификатору
        /// </summary>
        /// <param name="id">идентификатор книги</param>
        /// <returns>Объект класса Book, если книга найдена, иначе - null</returns>
        public Book? getBookById(long id) {
            return _bookRepository.GetBookById(id);
        }

        /// <summary>
        /// Сохранить книгу
        /// </summary>
        /// <param name="bookName">Название книги</param>
        /// <param name="yearOfPublishing">Год публикации</param>
        /// <param name="publisher">Издательство</param>
        /// <param name="ISBN">Международный идентификатор для книг</param>
        /// <param name="authorIds">Список идентификаторов авторов книги</param>
        /// <param name="genreIds">Список идентификаторов жанров книги</param>
        /// <returns></returns>
        public Book? saveBook(string bookName, int yearOfPublishing, string publisher, string ISBN, List<long> authorIds, List<long> genreIds) {
            Book book = new Book.Builder().WithTitle(bookName)
                .WithYearOfPublication(yearOfPublishing)
                .WithPublisher(publisher)
                .WithISBN(ISBN)
                .Build();

            return _bookRepository.SaveBook(book, authorIds, genreIds);
        }

        /// <summary>
        /// Добавить автора
        /// </summary>
        /// <param name="bookId">идентификатор книги</param>
        /// <param name="authorIds">идентификатор автора</param>
        /// <exception cref="ArgumentException">если автор или книга не найдены</exception>
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

        /// <summary>
        /// Обновить информацию о книге
        /// </summary>
        /// <param name="bookId">Идентификатор книги</param>
        /// <param name="bookName">Название книги</param>
        /// <param name="yearOfPublishing">Год публикации</param>
        /// <param name="publisher">Издатель</param>
        /// <param name="isbn">Международный идентификатор для книг</param>
        /// <param name="authorIds">Список идентификаторов авторов</param>
        /// <param name="genreIds">Список идентификаторов жанров</param>
        /// <returns></returns>
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

        /// <summary>
        /// Удалить книгу
        /// </summary>
        /// <param name="bookId">Идентификатор книги</param>
        /// <returns>true - если книга удалена, false - если книга не найдена</returns>
        public bool RemoveBook(long bookId) { 
            Book? book = _bookRepository.GetBookById(bookId);
            if(book == null) {
                return false;
            }

            _bookRepository.RemoveBook(book);
            return true;
        }
    }
}
