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
    public sealed class GenreRepositoryTest
    {
        private GenreRepository genreRepository;
        private Mock<LibraryDatabaseContext> mockedContext;

        [TestInitialize]
        public void SetupConfig()
        {
            mockedContext = new Mock<LibraryDatabaseContext>();
            genreRepository = new GenreRepository(mockedContext.Object);
        }

        [TestMethod]
        public void GetGenreById_WhenGenreExists_ThenReturnGenre()
        {
            long id = 1;
            Genre expected = new Genre { ID = 1, Name = "A" };
            mockedContext.Setup(d => d.Genres.Find(id)).Returns(expected);

            Genre? actual = genreRepository.GetGenreById(id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGenreById_WhenGenreNotFound_ThenReturnNull()
        {
            Genre? expected = null;
            long id = 1;
            mockedContext.Setup(d => d.Genres).Returns(CreateMockSet(new List<Genre>()).Object);

            Genre? actual = genreRepository.GetGenreById(id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGenreByName_WhenGenreExists_ThenReturnGenre()
        {
            string genreName = "A";
            Genre? expected = new Genre { Name = genreName };
            mockedContext.Setup(d => d.Genres).Returns(CreateMockSet([expected]).Object);

            Genre? actual = genreRepository.GetGenreByName(genreName);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGenreByName_WhenGenreNotFound_ThenReturnNull()
        {
            Genre? expected = null;
            string genreName = "something wrong";
            mockedContext.Setup(d => d.Genres).Returns(CreateMockSet(new List<Genre>()).Object);

            Genre? actual = genreRepository.GetGenreByName(genreName);

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
