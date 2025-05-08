using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.edit_book
{
    /// <summary>
    /// Интерфейс фабрики для создания формы изменения информации о книге
    /// </summary>
    public interface IEditBookFormFactory
    {
        /// <summary>
        /// Создать форму для изменения информации о книге
        /// </summary>
        /// <returns>Объект класса EditBookInfoForm - форма для изменения информации о книге</returns>
        EditBookInfoForm Create();
    }
}
