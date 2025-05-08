using Microsoft.EntityFrameworkCore;
using Moq;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.dto;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TEST_OOP_Sazonov_23VP1.repository
{
    [TestClass]
    public sealed class BookRepositoryTest
    {
        private BookRepository bookRepository;
        private Mock<LibraryDatabaseContext> context;

        [TestInitialize]
        public void Setup() {
            context = new Mock<LibraryDatabaseContext>();
            bookRepository = new BookRepository(context.Object);
        }

        [TestMethod]
        public void GetBookById_WhenBookWasFound_ThenReturnBook() {
            long id = 1;
            Book expected = new Book.Builder().WithTitle("A").WithYearOfPublication(2025).WithPublisher("P_A").Build();
            expected.Id = id;
            context.Setup(c => c.Books).Returns(CreateMockSet([expected]).Object);

            Book actual = bookRepository.GetBookById(id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBookById_WhenBookNotFound_ThenReturnNull()
        {
            long id = 1;
            Book? expected = null;
            context.Setup(c => c.Books).Returns(CreateMockSet(new List<Book>()).Object);

            Book? actual = bookRepository.GetBookById(id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveBook_WhenBookHasAlreadySaved_ThenReturnNull() {
            long id = 1;
            Book savedBook = new Book.Builder().WithTitle("A").WithYearOfPublication(2025).WithPublisher("P_A").Build();
            savedBook.Id = id;
            context.Setup(c => c.Books).Returns(CreateMockSet([savedBook]).Object);

            Book? actual = bookRepository.SaveBook(savedBook, [], []);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SaveBook_WhenBookHasNotAlreadySaved_ThenReturnBook()
        {
            long id = 1;
            Book expected = new Book.Builder().WithTitle("A").WithYearOfPublication(2025).WithPublisher("P_A").Build();
            expected.Id = id;
            context.Setup(c => c.Books).Returns(CreateMockSet(new List<Book>()).Object);

            Book? actual = bookRepository.SaveBook(expected, [], []);

            Assert.AreEqual(expected, actual);
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
