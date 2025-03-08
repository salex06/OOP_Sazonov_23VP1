using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.orm
{
    /// <summary>
    /// Таблица для хранения связей между книгой и жанрами
    /// </summary>
    [Table("BookGenres")]
    class BookGenresDb
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        [Required]
        public long GenreId { get; set; }

        /// <summary>
        /// Идентификатор книги
        /// </summary>
        [Required]
        public long BookId { get; set; }

        [ForeignKey("GenreId")]
        public virtual GenreDb Genre { get; set; }

        [ForeignKey("BookId")]
        public virtual BookDb Book { get; set; }
    }
}
