using Microsoft.EntityFrameworkCore;
using Moq;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TEST_OOP_Sazonov_23VP1.repository
{
    [TestClass]
    public sealed class LoanRepositoryTest
    {
        private LoanRepository loanRepository;
        private Mock<LibraryDatabaseContext> mockedContext;

        [TestInitialize]
        public void SetupConfig()
        {
            mockedContext = new Mock<LibraryDatabaseContext>();
            loanRepository = new LoanRepository(mockedContext.Object);
        }

        [TestMethod]
        public void CheckForIssue_WhenBookInLibrary_ThenReturnTrue() {
            long bookId = 5;
            List<Loan> loans = [
                    new Loan{ReaderId = 1, BookId = bookId, LoanDate = DateTime.Parse("21.12.2020"), ReturnDate = DateTime.Parse("25.12.2020")},
                    new Loan{ReaderId = 10, BookId = bookId, LoanDate = DateTime.Parse("10.02.2025"), ReturnDate = null}
                ];
            mockedContext.Setup(context => context.Loans).Returns(CreateMockSet(loans).Object);

            bool result = loanRepository.CheckForIssue(bookId);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckForIssue_WhenBookIsIssued_ThenReturnFalse()
        {
            long bookId = 5;
            List<Loan> loans = [
                    new Loan{ReaderId = 1, BookId = bookId, LoanDate = DateTime.Parse("21.12.2020"), ReturnDate = DateTime.Parse("25.12.2020")},
                    new Loan{ReaderId = 10, BookId = bookId, LoanDate = DateTime.Parse("10.02.2025"), ReturnDate = DateTime.Parse("15.02.2025")}
                ];
            mockedContext.Setup(context => context.Loans).Returns(CreateMockSet(loans).Object);

            bool result = loanRepository.CheckForIssue(bookId);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FindActiveIssue_WhenBookIsIssuedNow_ThenReturnLoan()
        {
            long bookId = 5;
            Loan expectedLoan = new Loan
            {
                ReaderId = 10,
                BookId = bookId,
                LoanDate = DateTime.Parse("10.02.2025"),
                ReturnDate = null
            };

            List<Loan> loans = [
                    new Loan{ReaderId = 1, BookId = bookId, LoanDate = DateTime.Parse("21.12.2020"), ReturnDate = DateTime.Parse("25.12.2020")},
                    expectedLoan
                ];
            mockedContext.Setup(context => context.Loans).Returns(CreateMockSet(loans).Object);

            Loan? actual = loanRepository.FindActiveIssue(bookId);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedLoan, actual);
        }

        [TestMethod]
        public void FindActiveIssue_WhenBookIsInLibraryNow_ThenReturnNull()
        {
            long bookId = 5;
            List<Loan> loans = [
                    new Loan{ReaderId = 1, BookId = bookId, LoanDate = DateTime.Parse("21.12.2020"), ReturnDate = DateTime.Parse("25.12.2020")}
                ];
            mockedContext.Setup(context => context.Loans).Returns(CreateMockSet(loans).Object);

            Loan? actual = loanRepository.FindActiveIssue(bookId);

            Assert.IsNull(actual);
        }

        private Mock<DbSet<T>> CreateMockSet<T>(List<T> data) where T : class
        {
            var queryableData = data.AsQueryable();

            var mockSet = new Mock<DbSet<T>>();
            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryableData.Provider);
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryableData.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryableData.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryableData.GetEnumerator());

            return mockSet;
        }
    }
}
