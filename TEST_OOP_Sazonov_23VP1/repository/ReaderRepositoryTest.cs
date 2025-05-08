using Microsoft.EntityFrameworkCore;
using Moq;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_OOP_Sazonov_23VP1.repository
{
    [TestClass]
    public sealed class ReaderRepositoryTest
    {
        private ReaderRepository readerRepository;
        private Mock<LibraryDatabaseContext> mockedContext;

        [TestInitialize]
        public void SetupConfig()
        {
            mockedContext = new Mock<LibraryDatabaseContext>();
            readerRepository = new ReaderRepository(mockedContext.Object);
        }

        [TestMethod]
        public void containsReader_WhenReaderNotFound_ThenReturnFalse() {
            long id = 1;
            mockedContext.Setup(context => context.Readers).Returns(CreateMockSet(new List<Reader>()).Object);

            bool result = readerRepository.containsReader(id);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void containsReader_WhenReaderWasFound_ThenReturnTrue()
        {
            long id = 1;
            mockedContext.Setup(context => context.Readers).Returns(CreateMockSet([new Reader { ID = 1 }]).Object);

            bool result = readerRepository.containsReader(id);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void getReaderById_WhenReaderNotFound_ThenReturnNull()
        {
            Reader? expected = null;
            long id = 1;
            mockedContext.Setup(d => d.Readers.Find(id)).Returns(expected);

            Reader? actual = readerRepository.getReaderById(id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetReaderById_WhenReaderExists_ThenReturnReader()
        {
            Reader? expected = new Reader { Name = "A", PhoneNumber = "+799900012345", Address = "Россия"};
            long id = 1;
            mockedContext.Setup(d => d.Readers.Find(id)).Returns(expected);

            Reader? actual = readerRepository.getReaderById(id);

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
