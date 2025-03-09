using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Модель отношения между автором и книгой
    /// </summary>
    class Authorship
    {
        /// <summary>
        /// Идентификатор записи в базе данных
        /// </summary>
        public long Id { get; private set; }
        /// <summary>
        /// Объект книги, связанной с автором
        /// </summary>
        public Book Book { get; private set; }
        /// <summary>
        /// Объект автора, связанный с книгой
        /// </summary>
        public Author Author { get; private set; }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="book">Книга</param>
        /// <param name="author">Автор</param>
        public Authorship(Book book, Author author)
        {
            Book = book;
            Author = author;
        }

        /// <summary>
        /// Конструктор для получения данных из БД
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="book">Книга</param>
        /// <param name="author">Автор</param>
        public Authorship(long id, Book book, Author author)
        {
            Id = id;
            Book = book;
            Author = author;
        }

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация об экземпляре класса в строковом формате</returns>
        public override string ToString()
        {
            return $"Авторство ID: {Id}, Книга: {Book.Title}, Автор: {Author.Name}";
        }
    }
}
