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
        public AuthorService(IAuthorRepository repository) {
            _authorRepository = repository;
        }

        public void SaveAuthor(string authorName, DateTime birthday) {
            DateOnly birthdayDateOnly = new DateOnly(birthday.Year, birthday.Month, birthday.Day);
            Author author = new Author { Name = authorName, Birthday = birthdayDateOnly };
            _authorRepository.SaveAuthor(author);
        }

        public Author? GetAuthor(long id) {
            return _authorRepository.GetAuthorById(id);
        }

        public List<Author> GetAuthor(string name) {
            return _authorRepository.GetAuthorByName(name);
        }

        public List<Author> GetAllAuthors() {
            return _authorRepository.GetAllAuthors();
        }
    }
}
