using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.remove_book
{
    /// <summary>
    /// Интерфейс фабрики для создания формы удаления книги
    /// </summary>
    public interface IRemoveBookFormFactory
    {
        /// <summary>
        /// Создать форму для удаления книги
        /// </summary>
        /// <returns>Объект класса RemoveBookForm - форма для удаления книги из системы</returns>
        RemoveBookForm Create();
    }
}
