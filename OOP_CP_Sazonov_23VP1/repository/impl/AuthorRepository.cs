using AutoMapper;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryDatabaseContext _context;

        public AuthorRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author? GetAuthorById(long id)
        {
            return _context.Authors.Find(id);
        }

        public List<Author> GetAuthorByName(string name)
        {
            var authors = _context.Authors.Select(author => author)
                .Where<Author>(author => (author.Name == name)).ToList();

            return (authors ?? []);
        }

        public void SaveAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }
}
