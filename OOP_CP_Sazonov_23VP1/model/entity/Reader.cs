using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.entity
{
    /// <summary>
    /// Модель читателя в системе
    /// </summary>
    public class Reader
    {
        /// <summary>
        /// Идентфикатор читателя
        /// </summary>
        public long ID { get; private set; }
        /// <summary>
        /// ФИО читателя
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Номер телефона читателя
        /// </summary>
        public string PhoneNumber { get; private set; }
        /// <summary>
        /// Адрес проживания читателя
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="name">ФИО читателя</param>
        /// <param name="phoneNumber">Номер телефона читателя</param>
        /// <param name="address">Адрес проживания читателя</param>
        public Reader(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        /// <summary>
        /// Конструктор для получения данных из БД
        /// </summary>
        /// <param name="id">Идентификатор читателя</param>
        /// <param name="name">ФИО читателя</param>
        /// <param name="phoneNumber">Номер телефона читателя</param>
        /// <param name="address">Адрес проживания читателя</param>
        public Reader(long id, string name, string phoneNumber, string address) : this(name, phoneNumber, address)
        {
            ID = id;
        }

        /// <summary>
        /// Установить новое ФИО
        /// </summary>
        /// <param name="name">Новые данные</param>
        public void SetName(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Установить новый номер телефона
        /// </summary>
        /// <param name="phoneNumber">Новые данные</param>
        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Установить новый адрес
        /// </summary>
        /// <param name="address">Новый адрес</param>
        public void SetAddress(string address)
        {
            Address = address;
        }

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация о классе в строковом формате</returns>
        public override string ToString()
        {
            return $"Читатель {Name}. Телефон: {PhoneNumber}. Адрес: {Address}";
            ;
        }
    }
}
