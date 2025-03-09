using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.service
{
    public class GenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository repository)
        {
            _genreRepository = repository;
        }

        public void SaveGenre(string genreName) {
            Genre genre = new Genre(genreName);

            if (!_genreRepository.SaveGenre(genre)) {
                throw new InvalidOperationException("Жанр уже добавлен");
            }
        }

        public Genre GetGenre(long id) {
            return _genreRepository.GetGenreById(id) ?? throw new InvalidOperationException("Жанр не найден");
        }

        public Genre GetGenre(string name) {
            return _genreRepository.GetGenreByName(name) ?? throw new InvalidOperationException("Жанр не найден");
        }

        public List<Genre> GetAllGenres() {
            return _genreRepository.GetAllGenres();
        }
    }
}
