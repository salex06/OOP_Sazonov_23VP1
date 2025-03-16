using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Класс представляет модель жанра в системе
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// Название жанра
        /// </summary>
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация о классе в строковом формате</returns>
        public override string ToString()
        {
            return $"ID жанра: {ID}. Жанр {Name}";
        }
    }
}
