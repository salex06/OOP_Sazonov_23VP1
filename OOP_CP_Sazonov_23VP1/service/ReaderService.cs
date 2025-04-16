using OOP_CP_Sazonov_23VP1.model.entity;
using OOP_CP_Sazonov_23VP1.repository;
using OOP_CP_Sazonov_23VP1.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.service
{
    public class ReaderService
    {
        private readonly IReaderRepository _readerRepository;
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="repository">Репозиторий для сущности Reader</param>
        public ReaderService(IReaderRepository repository)
        {
            _readerRepository = repository;
        }

        /// <summary>
        /// Получить список авторов в отсортированном и отфильтрованном виде
        /// </summary>
        /// <param name="orderBy_Value">поле, по которому проводится сортировка</param>
        /// <param name="isAscendingOrder">режим сортировки: по возрастанию/по умолчанию</param>
        /// <param name="filters">фильтры для поиска книг с конкретными значениями полей</param>
        /// <returns></returns>
        public KeyValuePair<List<Reader>, int> GetAllReaders(string orderBy_Value, bool isAscendingOrder, dto.ReaderFilterOptions filters) {
            return _readerRepository.getAllReaders(orderBy_Value, isAscendingOrder, filters);
        }

        /// <summary>
        /// Сохранить читателя
        /// </summary>
        /// <param name="readerName">Имя читателя</param>
        /// <param name="phoneNumber">Номер телефона читателя</param>
        /// <param name="address">Адрес читателя</param>
        /// <returns>Объект класса Reader - сохраненный читатель</returns>
        public Reader SaveReader(string readerName, string phoneNumber, string address) {
            Reader reader = new Reader.Builder()
                .WithName(readerName)
                .WithPhoneNumber(phoneNumber)
                .WithAddress(address)
                .Build();

            _readerRepository.saveReader(reader);

            return reader;
        }

        /// <summary>
        /// Удалить читателя
        /// </summary>
        /// <param name="readerId">Идентификатор читателя</param>
        /// <returns>true - если читатель удален, false - если читатель не найден</returns>
        public bool RemoveReader(long readerId) {
            Reader? reader = _readerRepository.getReaderById(readerId);
            if (reader == null) {
                return false;
            }
            _readerRepository.removeReader(reader);
            return true;
        }

        /// <summary>
        /// Получить читателя по его идентификатору
        /// </summary>
        /// <param name="readerId">Идентификатор читателя</param>
        /// <returns>Объект класса Reader, если читатель найден, иначе - false</returns>
        public Reader? GetReaderById(long readerId) {
            return _readerRepository.getReaderById(readerId);
        }

        /// <summary>
        /// Обновить информацию о читателе
        /// </summary>
        /// <param name="id">Идентификатор читателя</param>
        /// <param name="name">Имя читателя</param>
        /// <param name="phone">Номер телефона читателя</param>
        /// <param name="address">Адрес читателя</param>
        /// <returns>Объект класса Reader, если читатель найден, иначе - null</returns>
        public Reader? UpdateReader(long id, string name, string phone, string address) {
            Reader? reader = _readerRepository.getReaderById(id);

            if (reader == null)
            {
                return null;
            }

            reader.Name = name;
            reader.PhoneNumber = phone;
            reader.Address = address;

            return _readerRepository.updateReader(reader);
        }
    }
}
