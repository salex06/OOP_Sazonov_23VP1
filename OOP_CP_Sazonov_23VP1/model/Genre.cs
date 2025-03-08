using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model
{
    /// <summary>
    /// Класс представляет модель жанра в системе
    /// </summary>
    class Genre
    {
        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        public long ID { get; private set; }
        /// <summary>
        /// Название жанра
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="name">Название жанра</param>
        public Genre(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Конструктор для получения информации из БД
        /// </summary>
        /// <param name="id">Идентификатор жанра</param>
        /// <param name="name">Название жанра</param>
        public Genre(long id, string name)
        {
            ID = id;
            Name = name;
        }

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
