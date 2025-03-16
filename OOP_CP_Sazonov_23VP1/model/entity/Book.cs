using Microsoft.EntityFrameworkCore;
using OOP_CP_Sazonov_23VP1.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Модель книги в системе
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор книги
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Год публикации книги
        /// </summary>
        public int YearOfPublication { get; set; }
        /// <summary>
        /// Издательство, выпустившее книгу
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// Международный стандартный книжный номер
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// Логическая переменная для определения, выдана книга или нет
        /// </summary>
        public bool IsIssued { get; set; } = false;

        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        private Book() {
            Title = "НЕИЗВЕСТНО";
            YearOfPublication = 0;
            Publisher = "НЕИЗВЕСТНО";
            ISBN = "НЕИЗВЕСТНО";
        }

        public class Builder
        {
            private Book book = new Book();

            public Builder WithTitle(string title)
            {
                book.Title = string.IsNullOrEmpty(title) ? "НЕИЗВЕСТНО" : title;
                return this;
            }

            public Builder WithYearOfPublication(int yearOfPublication)
            {
                book.YearOfPublication = yearOfPublication;
                return this;
            }

            public Builder WithPublisher(string publisher)
            {
                book.Publisher = string.IsNullOrEmpty(publisher) ? "НЕИЗВЕСТНО" : publisher;
                return this;
            }

            public Builder WithISBN(string isbn)
            {
                book.ISBN = string.IsNullOrEmpty(isbn) ? "НЕИЗВЕСТНО" : isbn;
                return this;
            }

            public Book Build()
            {
                return book;
            }
        }
    }
}
