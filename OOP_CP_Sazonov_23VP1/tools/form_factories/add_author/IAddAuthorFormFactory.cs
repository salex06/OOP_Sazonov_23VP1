using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.add_author
{
    /// <summary>
    /// Интерфейс фабрики для создания формы добавления авторов
    /// </summary>
    public interface IAddAuthorFormFactory
    {
        /// <summary>
        /// Создать форму добавления автора
        /// </summary>
        /// <returns>Объект класса NewAuthorForm - форма для добавления автора</returns>
        public NewAuthorForm Create();
    }
}
