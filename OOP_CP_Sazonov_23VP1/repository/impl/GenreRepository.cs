using AutoMapper;
using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.model.orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    class GenreRepository : IGenreRepository
    {
        private readonly LibraryDatabaseContext _context;
        private readonly IMapper _mapper;

        public GenreRepository(LibraryDatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Genre> GetAllGenres()
        {
            return _context.Genres.Select(src => _mapper.Map<Genre>(src)).ToList();
        }

        public Genre? GetGenreById(long id)
        {
            GenreDb? genreDb = _context.Genres.Find(id);
            return (genreDb != null) ? _mapper.Map<Genre>(genreDb) : null;
        }

        public Genre? GetGenreByName(string name)
        {
            var genreDb = _context.Genres.Where(src => (src.Name == name))
                .Select(src => _mapper.Map<Genre>(src))
                .FirstOrDefault();
            return (genreDb != null) ? _mapper.Map<Genre>(genreDb) : null;
        }

        public bool SaveGenre(Genre genre)
        {
            if (GetGenreByName(genre.Name) != null) {
                return false;
            }

            var genreDb = _mapper.Map<GenreDb>(genre);
            _context.Genres.Add(genreDb);
            _context.SaveChanges();
            return true;
        }
    }
}
