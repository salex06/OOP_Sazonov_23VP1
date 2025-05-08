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
    public sealed class GenreServiceTest
    {
        private GenreService genreService;
        private Mock<GenreRepository> genreRepo;
        private Mock<LibraryDatabaseContext> context;

        [TestInitialize]
        public void Setup() {
            context = new Mock<LibraryDatabaseContext>();
            genreRepo = new Mock<GenreRepository>(context.Object);

            genreService = new GenreService(genreRepo.Object);
        }

        [TestMethod]
        public void SaveGenre_WhenGenreHasBeenAlreadySaved_ThenThrow() {
            string genreName = "A";
            string expected = "Жанр уже добавлен";
            genreRepo.Setup(g => g.SaveGenre(It.IsAny<Genre>())).Returns(false);

            var exception = Assert.ThrowsException<InvalidOperationException>(() => genreService.SaveGenre(genreName));

            Assert.AreEqual(expected, exception.Message);
        }

        [TestMethod]
        public void GetGenre_WhenGenreWasNotFound_ThenThrow()
        {
            int genreId = 1;
            string expected = "Жанр не найден";
            Genre? genre = null;
            genreRepo.Setup(g => g.GetGenreById(genreId)).Returns(genre);

            var exception = Assert.ThrowsException<InvalidOperationException>(() => genreService.GetGenre(genreId));

            Assert.AreEqual(expected, exception.Message);
        }

        [TestMethod]
        public void GetGenre_WhenGenreWasFound_ThenReturnGenre()
        {
            int genreId = 1;
            Genre? expected = new Genre {Name = "A", ID = genreId };
            genreRepo.Setup(g => g.GetGenreById(genreId)).Returns(expected);

            Genre actual = genreService.GetGenre(genreId);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GetGenreByName_WhenGenreWasNotFound_ThenThrow()
        {
            string genreName = "A";
            string expected = "Жанр не найден";
            Genre? genre = null;
            genreRepo.Setup(g => g.GetGenreByName(genreName)).Returns(genre);

            var exception = Assert.ThrowsException<InvalidOperationException>(() => genreService.GetGenre(genreName));

            Assert.AreEqual(expected, exception.Message);
        }

        [TestMethod]
        public void GetGenreByName_WhenGenreWasFound_ThenReturnGenre()
        {
            int genreId = 1;
            string genreName = "A";
            Genre? expected = new Genre { Name = genreName, ID = genreId };
            genreRepo.Setup(g => g.GetGenreByName(genreName)).Returns(expected);

            Genre actual = genreService.GetGenre(genreName);

            Assert.AreEqual(actual, expected);
        }
    }
}
