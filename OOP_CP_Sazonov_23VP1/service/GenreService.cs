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
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="repository">Репозиторий для сущности Genre</param>
        public GenreService(IGenreRepository repository)
        {
            _genreRepository = repository;
        }

        /// <summary>
        /// Сохранить жанр
        /// </summary>
        /// <param name="genreName">Название жанра</param>
        /// <exception cref="InvalidOperationException">если жанр уже существует</exception>
        public void SaveGenre(string genreName) {
            Genre genre = new Genre { Name = genreName };

            if (!_genreRepository.SaveGenre(genre)) {
                throw new InvalidOperationException("Жанр уже добавлен");
            }
        }

        /// <summary>
        /// Получить жанр по его идентификатору
        /// </summary>
        /// <param name="id">идентификатор жанра</param>
        /// <returns>объект класса Genre</returns>
        /// <exception cref="InvalidOperationException">если жанр не найден</exception>
        public Genre GetGenre(long id) {
            return _genreRepository.GetGenreById(id) ?? throw new InvalidOperationException("Жанр не найден");
        }

        /// <summary>
        /// Получить жанр по его названию
        /// </summary>
        /// <param name="name">название жанра</param>
        /// <returns>объект класса Genre</returns>
        /// <exception cref="InvalidOperationException">если жанр не найден</exception>
        public Genre GetGenre(string name) {
            return _genreRepository.GetGenreByName(name) ?? throw new InvalidOperationException("Жанр не найден");
        }

        /// <summary>
        /// Получить все жанры, сохраненные в БД
        /// </summary>
        /// <returns>Список жанров</returns>
        public List<Genre> GetAllGenres() {
            return _genreRepository.GetAllGenres();
        }
    }
}
