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
    /// Таблица для хранения связей авторов с книгами
    /// </summary>
    [Table("Authorship")]
    class AuthorshipDb
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public required long Id { get; set; }

        /// <summary>
        /// Идентификатор автора
        /// </summary>
        [Required]
        public required int AuthorId { get; set; }

        /// <summary>
        /// Идентификатор книги
        /// </summary>
        [Required]
        public required int BookId { get; set; }

        [ForeignKey("AuthorId")]
        public required virtual AuthorDb Author { get; set; }

        [ForeignKey("BookId")]
        public required virtual BookDb Book { get; set; }
    }
}
