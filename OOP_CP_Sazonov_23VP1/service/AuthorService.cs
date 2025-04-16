using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.service
{
    public class AuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="repository">Репозиторий, взаимодействующий с БД</param>
        public AuthorService(IAuthorRepository repository) {
            _authorRepository = repository;
        }

        /// <summary>
        /// Сохранить автора
        /// </summary>
        /// <param name="authorName">Имя автора</param>
        /// <param name="birthday">Дата рождения автора</param>
        public void SaveAuthor(string authorName, DateTime birthday) {
            DateOnly birthdayDateOnly = new DateOnly(birthday.Year, birthday.Month, birthday.Day);
            Author author = new Author { Name = authorName, Birthday = birthdayDateOnly };
            _authorRepository.SaveAuthor(author);
        }

        /// <summary>
        /// Найти автора по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор автора</param>
        /// <returns>объект класса Author, если автор найден, иначе - false</returns>
        public Author? GetAuthor(long id) {
            return _authorRepository.GetAuthorById(id);
        }

        /// <summary>
        /// Найти автора(-ов) по его имени
        /// </summary>
        /// <param name="name">Имя автора</param>
        /// <returns>Список авторов с подходящим именем</returns>
        public List<Author> GetAuthor(string name) {
            return _authorRepository.GetAuthorByName(name);
        }

        /// <summary>
        /// Получить всех авторов из БД
        /// </summary>
        /// <returns>Список авторов, сохраненных в БД</returns>
        public List<Author> GetAllAuthors() {
            return _authorRepository.GetAllAuthors();
        }
    }
}
