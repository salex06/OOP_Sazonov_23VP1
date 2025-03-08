using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_CP_Sazonov_23VP1.model.domain;

namespace OOP_CP_Sazonov_23VP1.model.orm
{
    /// <summary>
    /// Таблица для хранения данных о книгах
    /// </summary>
    [Table("Books")]
    class BookDb
    {
        /// <summary>
        /// Первичный ключ - идентификатор книги
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Название книги
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        /// <summary>
        /// Год публикации книги
        /// </summary>
        [Required]
        public int YearOfPublication { get; set; }
        /// <summary>
        /// Издательство, выпустившее книгу
        /// </summary>
        [Required]
        public string Publisher { get; set; }
        /// <summary>
        /// Международный стандартный книжный номер
        /// </summary>
        [Required]
        public string ISBN { get; set; }
        /// <summary>
        /// Логическая переменная для определения, выдана книга или нет
        /// </summary>
        [Required]
        public bool IsIssued { get; set; }

        /// <summary>
        /// Список авторов книг
        /// </summary>
        public virtual ICollection<AuthorshipDb> Authorships { get; set; }
        /// <summary>
        /// Список жанров книги
        /// </summary>
        public virtual ICollection<BookGenresDb> BookGenres { get; set; }
    }
}
