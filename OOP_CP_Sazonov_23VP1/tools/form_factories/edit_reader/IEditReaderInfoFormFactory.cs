using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.edit_reader
{
    /// <summary>
    /// Интерфейс фабрики для создания формы изменения информации о читателе
    /// </summary>
    public interface IEditReaderInfoFormFactory
    {
        /// <summary>
        /// Создать форму для изменения информации о читателе
        /// </summary>
        /// <returns>Объект класса EditReaderInfoForm - форма для изменения информации о читателе</returns>
        EditReaderInfoForm Create();
    }
}
