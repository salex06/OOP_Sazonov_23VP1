using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IGenreRepository
    {
        /// <summary>
        /// Сохранить жанр в системе
        /// </summary>
        /// <param name="genre">Жанр книги</param>
        /// <returns>true - если жанр сохранен, false - если жанр уже существует</returns>
        bool SaveGenre(Genre genre);
        /// <summary>
        /// Получить жанр по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор жанра</param>
        /// <returns>Объект класса Genre, если жанр найден, иначе - null</returns>
        Genre? GetGenreById(long id);
        /// <summary>
        /// Получить жанр по названию
        /// </summary>
        /// <param name="name">Название жанра</param>
        /// <returns>Объект класса Genre, если жанр найден, иначе - null</returns>
        Genre? GetGenreByName(string name);
        /// <summary>
        /// Получить все жанры
        /// </summary>
        /// <returns>Список жанров, сохраненных в системе</returns>
        List<Genre> GetAllGenres();
    }
}
