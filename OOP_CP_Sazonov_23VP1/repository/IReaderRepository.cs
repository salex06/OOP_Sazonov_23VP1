using OOP_CP_Sazonov_23VP1.model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.repository
{
    public interface IReaderRepository
    {
        /// <summary>
        /// Сохранить читателя в БД
        /// </summary>
        /// <param name="reader">объект класса Reader</param>
        /// <returns>объект класса Reader - сохраненный читатель</returns>
        Reader saveReader(Reader reader);
        /// <summary>
        /// Получить читателя по его идентификатору
        /// </summary>
        /// <param name="readerId">идентификатор читателя</param>
        /// <returns>объект класса Reader, если читатель найден, иначе - null</returns>
        Reader? getReaderById(long readerId);
        /// <summary>
        /// Получить всех читателей из БД в отсортированном и отфильтрованном виде
        /// </summary>
        /// <param name="orderBy_Value">поле, по которому производится сортировка</param>
        /// <param name="isAscendingOrder">режим сортировки: по возрастанию/по убыванию</param>
        /// <param name="filters">фильтры для поиска читателей с определенными значениями полей</param>
        /// <returns>Пара "список читателей - количество читателей в БД (без фильтрации)"</returns>
        KeyValuePair<List<Reader>, int> getAllReaders(string orderBy_Value, bool isAscendingOrder, dto.ReaderFilterOptions filters);
        /// <summary>
        /// Удалить читателя
        /// </summary>
        /// <param name="reader">Удаляемый читатель</param>
        void removeReader(Reader reader);
        /// <summary>
        /// Проверить, зарегистрирован ли читатель
        /// </summary>
        /// <param name="readerId">идентификатор читателя</param>
        /// <returns>true - если читатель зарегистрирован, false - иначе</returns>
        bool containsReader(long readerId);
        /// <summary>
        /// Обновить информацию о читателе
        /// </summary>
        /// <param name="reader">Объект класса Reader с обновленными полями</param>
        /// <returns>Читатель с обновленными данными</returns>
        Reader? updateReader(Reader reader);
    }
}
