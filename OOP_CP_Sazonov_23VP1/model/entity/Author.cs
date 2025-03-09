using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Модель автора книги
    /// </summary>
    class Author
    {
        /// <summary>
        /// Идентификатор автора в базе данных
        /// </summary>
        public long Id { get; private set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Дата рождения автора
        /// </summary>
        public DateTime Birthday { get; private set; }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="name">Имя автора</param>
        /// <param name="date">Дата рождения автора</param>
        public Author(string name, DateTime date)
        {
            Name = name;
            Birthday = date;
        }

        /// <summary>
        /// Конструктор для получения данных из БД
        /// </summary>
        /// <param name="id">Идентификатор автора</param>
        /// <param name="name">Имя автора</param>
        /// <param name="date">Дата рождения автора</param>
        public Author(long id, string name, DateTime date)
        {
            Id = id;
            Name = name;
            Birthday = date;
        }

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация о классе в строковом формате</returns>
        public override string ToString()
        {
            return $"Автор ID: {Id}, Имя: {Name}. Дата рождения: {Birthday}";
        }
    }
}
