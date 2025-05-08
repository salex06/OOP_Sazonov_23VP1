using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IAuthorRepository
    {
        /// <summary>
        /// Сохранить автора в БД
        /// </summary>
        /// <param name="author">объект типа "Автор"</param>
        void SaveAuthor(Author author);
        /// <summary>
        /// Получить автора по его идентификатору
        /// </summary>
        /// <param name="id">идентификатор автора</param>
        /// <returns>объект класса "Author" или null, если не найден</returns>
        Author? GetAuthorById(long id);
        /// <summary>
        /// Найти авторов по имени
        /// </summary>
        /// <param name="name">Имя автора</param>
        /// <returns>Список авторов с переданным именем</returns>
        List<Author> GetAuthorByName(string name);
        /// <summary>
        /// Получить всех авторов из БД
        /// </summary>
        /// <returns>Список авторов, сохраненных в БД</returns>
        List<Author> GetAllAuthors();
    }
}
