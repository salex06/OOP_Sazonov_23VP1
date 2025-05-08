using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryDatabaseContext _context;

        public AuthorRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public virtual List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public virtual Author? GetAuthorById(long id)
        {
            return _context.Authors.Find(id);
        }

        public virtual List<Author> GetAuthorByName(string name)
        {
            var authors = _context.Authors.Select(author => author)
                .Where<Author>(author => (author.Name == name)).ToList();

            return (authors ?? []);
        }

        public virtual void SaveAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }
}
