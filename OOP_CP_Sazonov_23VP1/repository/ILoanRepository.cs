using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface ILoanRepository
    {
        /// <summary>
        /// Получить запись о выдаче книги по идентификатору
        /// </summary>
        /// <param name="id">идентификатор записи</param>
        /// <returns>Объект класса Loan, если запись найдена, иначе - false</returns>
        Loan? GetById(long id);
        /// <summary>
        /// Получить все записи о выдаче книг
        /// </summary>
        /// <returns>Набор записей из БД</returns>
        IEnumerable<Loan> GetAll();
        /// <summary>
        /// Добавить запись о выдаче книги в БД
        /// </summary>
        /// <param name="loan">Запись о выдаче книги</param>
        void Add(Loan loan);
        /// <summary>
        /// Обновить запись о выдаче книги
        /// </summary>
        /// <param name="loan">Запись о выдаче книги</param>
        void Update(Loan loan);
        /// <summary>
        /// Удалить запись о выдаче книги
        /// </summary>
        /// <param name="id">идентификатор записи о выдаче</param>
        void Delete(long id);
        /// <summary>
        /// Проверить, выдана ли книга
        /// </summary>
        /// <param name="bookId">Идентификатор книги</param>
        /// <returns>true - если книга выдана, false - если книга в библиотеке</returns>
        bool CheckForIssue(long bookId);
        /// <summary>
        /// Найти активную запись о выдаче книги
        /// (то есть книга ещё не возвращена)
        /// </summary>
        /// <param name="bookId">идентификатор книги</param>
        /// <returns>Объект класса Loan, если запись найдена, иначе - false</returns>
        Loan? FindActiveIssue(long bookId);
    }
}
