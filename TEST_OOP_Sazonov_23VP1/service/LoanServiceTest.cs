using Moq;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository.impl;
using OOP_CP_Sazonov_23VP1.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_OOP_Sazonov_23VP1.service
{
    [TestClass]
    public sealed class LoanServiceTest
    {
        private Mock<LoanRepository> loanRepo;
        private Mock<BookRepository> bookRepo;
        private Mock<ReaderRepository> readerRepo;
        private Mock<LibraryDatabaseContext> context;
        private LoanService loanService;

        [TestInitialize]
        public void Setup() {
            context = new Mock<LibraryDatabaseContext>();
            loanRepo = new Mock<LoanRepository>(context.Object);
            bookRepo = new Mock<BookRepository>(context.Object);
            readerRepo = new Mock<ReaderRepository>(context.Object);

            loanService = new LoanService(loanRepo.Object, readerRepo.Object, bookRepo.Object);
        }

        [TestMethod]
        public void ReturnBook_WhenBookHasAlreadyBeenReturned_ThenThrow() {
            long bookId = 1;
            Loan? expected = null;
            string expectedMessage = $"Книга с ID {bookId} не выдана или уже возвращена.";
            loanRepo.Setup(l => l.FindActiveIssue(bookId)).Returns(expected);

            var exception = Assert.ThrowsException<InvalidOperationException>(() => loanService.ReturnBook(bookId));
            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [TestMethod]
        public void LendBook_WhenReaderNotFound_ThenThrow()
        {
            long readerId = 1;
            long bookId = 2;
            DateTime dueDate = DateTime.Now;
            Reader? expected = null;
            string expectedMessage = $"Читатель с ID {readerId} не найден.";
            readerRepo.Setup(l => l.getReaderById(readerId)).Returns(expected);

            var exception = Assert.ThrowsException<ArgumentException>(() => loanService.LendBook(readerId, bookId, dueDate));
            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [TestMethod]
        public void LendBook_WhenBookNotFound_ThenThrow()
        {
            long readerId = 1;
            long bookId = 2;
            DateTime dueDate = DateTime.Now;
            Reader? reader = new Reader { Name= "Ivan Ivanov", PhoneNumber = "+12345", Address = "Penza"};
            Book? book = null;
            string expectedMessage = $"Книга с ID {bookId} не найдена.";
            readerRepo.Setup(l => l.getReaderById(readerId)).Returns(reader);
            bookRepo.Setup(b => b.GetBookById(bookId)).Returns(book);

            var exception = Assert.ThrowsException<ArgumentException>(() => loanService.LendBook(readerId, bookId, dueDate));
            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [TestMethod]
        public void LendBook_WhenBookHasBeenAlreadyIssues_ThenThrow()
        {
            long readerId = 1;
            long bookId = 2;
            DateTime dueDate = DateTime.Now;
            Reader? reader = new Reader { Name = "Ivan Ivanov", PhoneNumber = "+12345", Address = "Penza" };
            Book? book = new Book.Builder().Build();
            string expectedMessage = $"Книга с ID {bookId} уже выдана и не возвращена.";
            readerRepo.Setup(l => l.getReaderById(readerId)).Returns(reader);
            bookRepo.Setup(b => b.GetBookById(bookId)).Returns(book);
            loanRepo.Setup(c => c.CheckForIssue(bookId)).Returns(true);

            var exception = Assert.ThrowsException<InvalidOperationException>(() => loanService.LendBook(readerId, bookId, dueDate));
            Assert.AreEqual(expectedMessage, exception.Message);
        }
    }
}
