using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.add_reader
{
    /// <summary>
    /// Интерфейс фабрики для создания формы добавления читателя
    /// </summary>
    public interface IAddReaderFormFactory
    {
        /// <summary>
        /// Создать форму добавления читателя
        /// </summary>
        /// <returns>Объект класса AddReaderForm - форма для добавления читателя</returns>
        AddReaderForm Create();
    }
}
