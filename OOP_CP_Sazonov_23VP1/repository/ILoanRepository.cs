using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface ILoanRepository
    {
        Loan? GetById(long id);
        IEnumerable<Loan> GetAll();
        void Add(Loan loan);
        void Update(Loan loan);
        void Delete(long id);
        bool CheckForIssue(long bookId);
        Loan? FindActiveIssue(long bookId);
    }
}
