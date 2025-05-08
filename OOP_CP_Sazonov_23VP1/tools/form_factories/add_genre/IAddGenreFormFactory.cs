using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.add_genre
{
    /// <summary>
    /// Интерфейс фабрики для создания формы добавления жанра
    /// </summary>
    public interface IAddGenreFormFactory
    {
        /// <summary>
        /// Создать форму для добавления жанра
        /// </summary>
        /// <returns>Объект класса AddGenreForm - форма для добавления жанра</returns>
        AddGenreForm Create();
    }
}
