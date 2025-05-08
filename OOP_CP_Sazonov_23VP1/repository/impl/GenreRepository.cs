using OOP_CP_Sazonov_23VP1.context;
using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository.impl
{
    public class GenreRepository : IGenreRepository
    {
        private readonly LibraryDatabaseContext _context;

        public GenreRepository(LibraryDatabaseContext context)
        {
            _context = context;
        }

        public List<Genre> GetAllGenres()
        {
            return _context.Genres.Select(src => src).ToList();
        }

        public virtual Genre? GetGenreById(long id)
        {
            return _context.Genres.Find(id);
        }

        public virtual Genre? GetGenreByName(string name)
        {
            return _context.Genres.Where(src => (src.Name == name))
                .Select(src => src)
                .FirstOrDefault(); ;
        }

        public virtual bool SaveGenre(Genre genre)
        {
            if (GetGenreByName(genre.Name) != null) {
                return false;
            }

            _context.Genres.Add(genre);
            _context.SaveChanges();
            return true;
        }
    }
}
