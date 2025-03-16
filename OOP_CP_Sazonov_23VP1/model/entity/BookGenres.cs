using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Класс представляет отношение между жанрами и книгами
    /// </summary>
    public class BookGenres
    {
        /// <summary>
        /// Идентификатор в БД
        /// </summary>
        public long Id { get; private set; }
        /// <summary>
        /// Книга, связанная с жанром
        /// </summary>
        public Book Book { get; private set; }
        /// <summary>
        /// Жанр, связанный с книгой
        /// </summary>
        public Genre Genre { get; private set; }

        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="book">Книга</param>
        /// <param name="genre">Жанр</param>
        public BookGenres(Book book, Genre genre)
        {
            Book = book;
            Genre = genre;
        }

        /// <summary>
        /// Конструктор для получения информации из БД
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="book">Книга</param>
        /// <param name="genre">Жанр</param>
        public BookGenres(long id, Book book, Genre genre)
        {
            Id = id;
            Book = book;
            Genre = genre;
        }

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация о классе в строковом формате</returns>
        public override string ToString()
        {
            return $"Жанр книги ID: {Id}, Книга: {Book.Title}, Жанр: {Genre.Name}";
        }
    }
}
