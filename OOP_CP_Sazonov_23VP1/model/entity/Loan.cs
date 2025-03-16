using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Модель записи о выдаче книги в системе
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public long Id { get; private set; }
        /// <summary>
        /// Читатель, получивший книгу
        /// </summary>
        public Reader Reader { get; private set; }
        /// <summary>
        /// Выданная книга
        /// </summary>
        public Book Book { get; private set; }
        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime StartDate { get; private set; }
        /// <summary>
        /// Дата возврата книги
        /// </summary>
        public DateTime? EndDate { get; private set; } = null;
        /// <summary>
        /// Срок выдачи книги
        /// </summary>
        public DateTime DateOfIssue { get; private set; }

        /// <summary>
        /// Конструктор с 4 параметрами
        /// </summary>
        /// <param name="reader">Читатель</param>
        /// <param name="book">Книга</param>
        /// <param name="startDate">Дата выдачи</param>
        /// <param name="dateOfIssue">Срок выдачи</param>
        /// <exception cref="InvalidOperationException">Если книга уже выдана</exception>
        public Loan(Reader reader, Book book, DateTime startDate, DateTime dateOfIssue)
        {
            Reader = reader;
            Book = book;

            if (Book.IsLoaned())
            {
                throw new InvalidOperationException($"Книга '{Book.Title}' уже выдана.");
            }

            StartDate = startDate;
            DateOfIssue = dateOfIssue;

            Book.MarkAsLoaned(this);
        }

        /// <summary>
        /// Конструктор для получения данных из БД
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        /// <param name="reader">Читатель</param>
        /// <param name="book">Книга</param>
        /// <param name="startDate">Дата выдачи</param>
        /// <param name="endDate">Дата возврата</param>
        /// <param name="dateOfIssue">Срок выдачи</param>
        public Loan(long id, Reader reader, Book book, DateTime startDate, DateTime? endDate, DateTime dateOfIssue)
        {
            Id = id;
            Reader = reader;
            Book = book;
            StartDate = startDate;
            EndDate = endDate;
            DateOfIssue = dateOfIssue;
        }

        /// <summary>
        /// Возвратить книгу
        /// </summary>
        /// <param name="returnDate">Дата возврата</param>
        /// <exception cref="InvalidOperationException">Если книга уже возвращена</exception>
        public void ReturnBook(DateTime returnDate)
        {
            if (EndDate.HasValue)
            {
                throw new InvalidOperationException("Книга уже была возвращена.");
            }

            EndDate = returnDate;
            Book.MarkAsAvailable(); 
        }

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация о классе в строковом формате</returns>
        public override string ToString()
        {
            return $"Выдача ID: {Id}, Читатель: {Reader.Name}, Книга: {Book.Title}. " +
                $"Дата выдачи: {StartDate}, дата возврата: {EndDate?.ToLongDateString() ?? "не возвращена"} (срок выдачи: {DateOfIssue})";
        }
    }
}
