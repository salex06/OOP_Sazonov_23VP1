using Microsoft.EntityFrameworkCore;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.service
{
    public class LoanService
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IReaderRepository _readerRepository;

        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="loanRepository">Репозиторий для сущностей Loan</param>
        /// <param name="readerRepository">Репозиторий для сущностей Reader</param>
        /// <param name="bookRepository">Репозиторий для сущностей Book</param>
        public LoanService(ILoanRepository loanRepository, IReaderRepository readerRepository, IBookRepository bookRepository)
        {

            _loanRepository = loanRepository;
            _readerRepository = readerRepository;
            _bookRepository = bookRepository;
        }

        /// <summary>
        /// Выдать книгу
        /// </summary>
        /// <param name="readerId">идентификатор читателя</param>
        /// <param name="bookId">идентификатор книги</param>
        /// <param name="dueDate">срок выдачи</param>
        /// <exception cref="ArgumentException">если читатель или книга не найдены</exception>
        /// <exception cref="InvalidOperationException">если книга уже выдана</exception>
        public void LendBook(long readerId, long bookId, DateTime dueDate) {
            Reader? reader = _readerRepository.getReaderById(readerId);
            Book? book = _bookRepository.GetBookById(bookId);

            if (reader == null)
            {
                throw new ArgumentException($"Читатель с ID {readerId} не найден.");
            }

            if (book == null)
            {
                throw new ArgumentException($"Книга с ID {bookId} не найдена.");
            }

            if (_loanRepository.CheckForIssue(bookId))
            {
                throw new InvalidOperationException($"Книга с ID {bookId} уже выдана и не возвращена.");
            }

            Loan loan = new Loan
            {
                ReaderId = readerId,
                BookId = bookId,
                LoanDate = DateTime.Now,
                DueDate = dueDate,
                ReturnDate = null
            };

            _loanRepository.Add(loan);
        }

        /// <summary>
        /// Возвратить книгу
        /// </summary>
        /// <param name="bookId">идентификатор книги</param>
        /// <exception cref="InvalidOperationException">если книга уже возвращена или не выдана</exception>
        public void ReturnBook(long bookId) {
            Loan? loan = _loanRepository.FindActiveIssue(bookId);

            if (loan == null)
            {
                throw new InvalidOperationException($"Книга с ID {bookId} не выдана или уже возвращена.");
            }

            loan.ReturnDate = DateTime.Now;
            _loanRepository.Update(loan);
        }
    }
}
