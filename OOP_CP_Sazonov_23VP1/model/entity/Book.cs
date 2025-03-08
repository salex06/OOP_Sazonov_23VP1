using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.domain
{
    /// <summary>
    /// Модель книги в системе
    /// </summary>
    class Book
    {
        /// <summary>
        /// Идентификатор книги
        /// </summary>
        public long Id { get; private set; }
        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; private set; }
        /// <summary>
        /// Год публикации книги
        /// </summary>
        public int YearOfPublication { get; private set; }
        /// <summary>
        /// Издательство, выпустившее книгу
        /// </summary>
        public string Publisher { get; private set; }
        /// <summary>
        /// Международный стандартный книжный номер
        /// </summary>
        public string ISBN { get; private set; }
        /// <summary>
        /// Логическая переменная для определения, выдана книга или нет
        /// </summary>
        public bool IsIssued { get; private set; } = false;
        /// <summary>
        /// Объект выдачи книги. Если книга не выдана - null
        /// </summary>
        public Loan? Loan { get; set; } = null;

        private readonly List<Authorship> _authorships = new List<Authorship>();
        /// <summary>
        /// Список авторов книги
        /// </summary>
        public IReadOnlyCollection<Authorship> Authorships => _authorships.AsReadOnly();

        private readonly List<BookGenres> _genres = new List<BookGenres>();
        /// <summary>
        /// Список жанров книги
        /// </summary>
        public IReadOnlyCollection<BookGenres> Genres => _genres.AsReadOnly();

        /// <summary>
        /// Конструктор с 4 параметрами
        /// </summary>
        /// <param name="title">Название книги</param>
        /// <param name="yearOfPublication">Год публикации</param>
        /// <param name="publisher">Издательство</param>
        /// <param name="isbn">Международный стандартный книжный номер</param>
        public Book(string title, int yearOfPublication, string publisher, string isbn)
        {
            Title = title;
            YearOfPublication = yearOfPublication;
            Publisher = publisher;
            ISBN = isbn;
        }

        /// <summary>
        /// Конструктор для получения данных из БД
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        /// <param name="title">Название книги</param>
        /// <param name="yearOfPublication">Год публикации</param>
        /// <param name="publisher">Издательство</param>
        /// <param name="isbn">Международный стандартный книжный номер</param>
        public Book(long id, string title, int yearOfPublication, string publisher, string isbn)
        {
            Id = id;
            Title = title;
            YearOfPublication = yearOfPublication;
            Publisher = publisher;
            ISBN = isbn;
        }

        /// <summary>
        /// Добавить автора для данной книги
        /// </summary>
        /// <param name="author">Новый автор</param>
        /// <exception cref="InvalidOperationException">Если автор уже добавлен для этой книги</exception>
        public void AddAuthor(Author author)
        {
            if (_authorships.Any(a => a.Author == author))
            {
                throw new InvalidOperationException($"Автор '{author.Name}' уже является автором этой книги.");
            }

            var authorship = new Authorship(this, author);
            _authorships.Add(authorship);
        }

        /// <summary>
        /// Удалить автора для данной книги
        /// </summary>
        /// <param name="author">Удаляемый автор</param>
        /// <exception cref="InvalidOperationException">Если данный автор не является автором книги</exception>
        public void RemoveAuthor(Author author)
        {
            var authorship = _authorships.FirstOrDefault(a => a.Author == author);
            if (authorship == null)
            {
                throw new InvalidOperationException($"Автор '{author.Name}' не является автором этой книги.");
            }
            _authorships.Remove(authorship);
        }

        /// <summary>
        /// Добавить жанр для данной книги
        /// </summary>
        /// <param name="genre">Жанр</param>
        /// <exception cref="InvalidOperationException">Если жанр уже добавлен</exception>
        public void AddGenre(Genre genre)
        {
            if (_genres.Any(a => a.Genre == genre))
            {
                throw new InvalidOperationException($"Жанр '{genre.Name}' уже добавлен.");
            }

            var newGenre = new BookGenres(this, genre);
            _genres.Add(newGenre);
        }

        /// <summary>
        /// Удалить жанр для данной книги
        /// </summary>
        /// <param name="genre">Жанр</param>
        /// <exception cref="InvalidOperationException">Если жанр не относится к данной книге</exception>
        public void RemoveGenre(Genre genre)
        {
            var bookGenre = _genres.FirstOrDefault(a => a.Genre == genre);
            if (bookGenre == null)
            {
                throw new InvalidOperationException($"Жанр '{genre.Name}' не является жанром этой книги.");
            }
            _genres.Remove(bookGenre);
        }

        /// <summary>
        /// Проверить, выдана ли книга
        /// </summary>
        /// <returns>Если выдана - true, иначе - false</returns>
        public bool IsLoaned()
        {
            return Loan != null && Loan.EndDate == null;
        }

        /// <summary>
        /// Выдать книгу
        /// </summary>
        /// <param name="loan">Запись о выдаче книги</param>
        /// <exception cref="InvalidOperationException">Если книга уже выдана</exception>
        public void MarkAsLoaned(Loan loan)
        {
            if (IsLoaned())
            {
                throw new InvalidOperationException($"Книга '{Title}' уже выдана.");
            }

            IsIssued = true;
            Loan = loan;
        }

        /// <summary>
        /// Возвратить книгу
        /// </summary>
        public void MarkAsAvailable()
        {
            IsIssued = false;
            Loan = null;
        }

        /// <summary>
        /// Установить новое название книги
        /// </summary>
        /// <param name="title">Название книги</param>
        public void SetTitle(string title)
        {
            Title = title;
        }

        /// <summary>
        /// Установить новый год выпуска
        /// </summary>
        /// <param name="yearOfPublication">Год выпуска книги</param>
        public void SetYearOfPublication(int yearOfPublication)
        {
            YearOfPublication = yearOfPublication;
        }

        /// <summary>
        /// Установить нового издателя
        /// </summary>
        /// <param name="publisher">Издательство</param>
        public void SetPublisher(string publisher) {
            Publisher = publisher;
        }

        /// <summary>
        /// Установить новый ISBN
        /// </summary>
        /// <param name="isbn">Международный стандартный книжный номер</param>
        public void SetISBN(string isbn)
        {
            ISBN = isbn;
        }

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация о классе в строковом формате</returns>
        public override string ToString()
        {
            return $"Книга ID: {Id}, Название: {Title}, Авторы: {string.Join(", ", Authorships.Select(a => a.Author.Name))}, Выдана: {IsIssued}";
        }
    }
}
