﻿using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.lend_book
{
    /// <summary>
    /// Интерфейс фабрики для создания формы выдачи книги
    /// </summary>
    public interface ILendBookFormFactory
    {
        /// <summary>
        /// Создать форму выдачи книги
        /// </summary>
        /// <returns>Объект класса GiveOutABookForm - форма для выдачи книги читателю</returns>
        GiveOutABookForm Create();
    }
}
