using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryDatabaseContext _context;

        public LoanRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public void Add(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public virtual bool CheckForIssue(long bookId)
        {
            return _context.Loans.Any(l => l.BookId == bookId && l.ReturnDate == null);
        }

        public void Delete(long id)
        {
            var loan = _context.Loans.Find(id);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
                _context.SaveChanges();
            }
        }

        public virtual Loan? FindActiveIssue(long bookId)
        {
            return _context.Loans.FirstOrDefault(l => l.BookId == bookId && l.ReturnDate == null);
        }

        public IEnumerable<Loan> GetAll()
        {
            return _context.Loans.ToList();
        }

        public Loan? GetById(long id)
        {
            return _context.Loans.Find(id);
        }

        public void Update(Loan loan)
        {
            _context.Loans.Update(loan);
            _context.SaveChanges();
        }


    }
}
