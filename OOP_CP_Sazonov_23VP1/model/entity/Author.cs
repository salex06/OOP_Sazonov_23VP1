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
    public class Author
    {
        /// <summary>
        /// Идентификатор автора в базе данных
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата рождения автора
        /// </summary>
        public DateOnly Birthday { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
