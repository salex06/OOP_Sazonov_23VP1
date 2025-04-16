using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.remove_reader
{
    /// <summary>
    /// Интерфейс фабрики для создания формы удаления читателя
    /// </summary>
    public interface IRemoveReaderFormFactory
    {
        /// <summary>
        /// Создать форму для удаления читателя
        /// </summary>
        /// <returns>Объект класса RemoveReaderForm - форма для удаления читателя из системы</returns>
        RemoveReaderForm Create();
    }
}
