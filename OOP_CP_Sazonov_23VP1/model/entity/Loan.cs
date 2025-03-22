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
        public long Id { get; set; }
        public long ReaderId { get; set; }
        public Reader Reader { get; set; }
        public long BookId { get; set; }
        public Book Book { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
