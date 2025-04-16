using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.add_book
{
    /// <summary>
    /// Интерфейс фабрики для создания формы добавления книги
    /// </summary>
    public interface IAddBookFormFactory
    {
        /// <summary>
        /// Создать форму добавления книги
        /// </summary>
        /// <returns>Объект класса AddBookForm - форма для добавления книги</returns>
        AddBookForm Create();
    }
}
