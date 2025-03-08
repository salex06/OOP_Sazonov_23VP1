using AutoMapper;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.domain;
using OOP_CP_Sazonov_23VP1.model.orm;
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
        private readonly IMapper _mapper;

        public AuthorRepository(LibraryDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.Select(authorDb => _mapper.Map<Author>(authorDb)).ToList();
        }

        public Author? GetAuthorById(long id)
        {
            var authorDb =  _context.Authors.Find(id);
            return (authorDb != null) ? _mapper.Map<Author>(authorDb) : null;
        }

        public List<Author> GetAuthorByName(string name)
        {
            var authorsDb = _context.Authors.Select(authorDb => _mapper.Map<Author>(authorDb))
                .Where<Author>(authorDb => (authorDb.Name == name)).ToList();

            return (authorsDb ?? []);
        }

        public void SaveAuthor(Author author)
        {
            var authorDb = _mapper.Map<AuthorDb>(author);
            _context.Authors.Add(authorDb);
            _context.SaveChanges();
        }
    }
}
