using OOP_CP_Sazonov_23VP1.model.domain;
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
    /// Таблица для хранения данных о выдаче/возврате книг
    /// </summary>
    [Table("Loans")]
    class LoanDb
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [Key]
        public required long Id { get; set; }
        /// <summary>
        /// Читатель, получивший книгу
        /// </summary>
        [Required]
        public required int ReaderId { get; set; }
        /// <summary>
        /// Выданная книга
        /// </summary>
        [Required]
        public required int BookId { get; set; }
        /// <summary>
        /// Дата выдачи
        /// </summary>
        [Required]
        public required DateTime StartDate { get; set; }
        /// <summary>
        /// Дата возврата книги
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Срок выдачи книги
        /// </summary>
        [Required]
        public required DateTime DateOfIssue { get; set; }


        [ForeignKey("ReaderId")]
        public required virtual ReaderDb Reader { get; set; }

        [ForeignKey("BookId")]
        public required virtual BookDb Book { get; set; }
    }
}
