﻿using OOP_CP_Sazonov_23VP1.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.tools.form_factories.return_book
{
    /// <summary>
    /// Интерфейс фабрики для создания формы возврата книги
    /// </summary>
    public interface IReturnBookFormFactory
    {
        /// <summary>
        /// Создать форму для возврата книги
        /// </summary>
        /// <returns>Объект класса ReturnBookForm - форма для возврата книги</returns>
        ReturnBookForm Create();
    }
}
