using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.repository.impl;
using Moq;
using OOP_CP_Sazonov_23VP1.model.entity;
using Microsoft.EntityFrameworkCore;

namespace TEST_OOP_Sazonov_23VP1.repository
{
    [TestClass]
    public sealed class AuthorRepositoryTest
    {
        private AuthorRepository authorRepository;
        private Mock<LibraryDatabaseContext> mockedContext;

        [TestInitialize]
        public void SetupConfig() {
            mockedContext = new Mock<LibraryDatabaseContext>();
            authorRepository = new AuthorRepository(mockedContext.Object);
        }

        [TestMethod]
        public void GetAllAuthors_WhenNoAuthors_ThenReturnEmptyList()
        {
            mockedContext.Setup(context => context.Authors).Returns(CreateMockSet(new List<Author>()).Object);

            List<Author> actual = authorRepository.GetAllAuthors();

            Assert.AreEqual(0, actual.Count());
        }

        [TestMethod]
        public void GetAllAuthors_WhenAuthorsExist_ThenReturnAuthorList()
        {
            List<Author> expected = [
                    new Author{ Name = "A", Birthday = DateOnly.Parse("21.12.1940")},
                    new Author{ Name = "B", Birthday = DateOnly.Parse("12.01.1656")}
                ];
            mockedContext.Setup(d => d.Authors).Returns(CreateMockSet(expected).Object);

            List<Author> actual = authorRepository.GetAllAuthors();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAuthorById_WhenAuthorNotFound_ThenReturnNull()
        {
            Author? expected = null;
            long id = 1;
            mockedContext.Setup(d => d.Authors.Find(id)).Returns(expected);

            Author? actual = authorRepository.GetAuthorById(id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAuthorById_WhenAuthorExists_ThenReturnAuthor()
        {
            Author? expected = new Author { Name = "A", Birthday = DateOnly.Parse("21.12.1940") };
            long id = 1;
            mockedContext.Setup(d => d.Authors.Find(id)).Returns(expected);

            Author? actual = authorRepository.GetAuthorById(id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAuthorByName_WhenAuthorNotFound_ThenReturnEmptyList()
        {
            string name = "nobody";
            mockedContext.Setup(d => d.Authors).Returns(CreateMockSet(new List<Author>()).Object);

            List<Author> actual = authorRepository.GetAuthorByName(name);

            Assert.AreEqual(0, actual.Count());
        }

        [TestMethod]
        public void GetAuthorByName_WhenAuthorExists_ThenReturnAuthorList()
        {
            string name = "A";
            List<Author> expected =  [new Author { Name = "A", Birthday = DateOnly.Parse("21.12.1940") }];
            mockedContext.Setup(d => d.Authors).Returns(CreateMockSet(expected).Object);

            List<Author> actual = authorRepository.GetAuthorByName(name);

            CollectionAssert.AreEqual(expected, actual);
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
