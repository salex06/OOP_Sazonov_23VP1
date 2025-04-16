using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Модель записи о выдаче книги в системе
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Идентификатор читателя, которому выдается книга
        /// </summary>
        public long ReaderId { get; set; }
        /// <summary>
        /// Сущность "Читатель", которому выдается книга
        /// </summary>
        public Reader Reader { get; set; }
        /// <summary>
        /// Идентификатор выдаваемой книги
        /// </summary>
        public long BookId { get; set; }
        /// <summary>
        /// Сущность "Книга" для выдачи
        /// </summary>
        public Book Book { get; set; }
        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime LoanDate { get; set; }
        /// <summary>
        /// Срок сдачи
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Дата сдачи
        /// </summary>
        public DateTime? ReturnDate { get; set; }
    }
}
