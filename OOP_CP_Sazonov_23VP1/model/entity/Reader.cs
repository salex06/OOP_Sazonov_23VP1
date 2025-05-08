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
        public long ID { get; set; }
        /// <summary>
        /// ФИО читателя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Номер телефона читателя
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Адрес проживания читателя
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Набор записей о выдаче книг
        /// </summary>
        public ICollection<Loan> Loans { get; set; } = new List<Loan>(); 

        /// <summary>
        /// Представление класса в виде строки
        /// </summary>
        /// <returns>Информация о классе в строковом формате</returns>
        public override string ToString()
        {
            return $"Читатель {Name}. Телефон: {PhoneNumber}. Адрес: {Address}";
        }
        /// <summary>
        /// Строитель объекта типа Reader. Используется
        /// для гибкого создания экземпляра класса
        /// </summary>
        public class Builder
        {
            private string _name;
            private string _phoneNumber;
            private string _address;

            public Builder WithName(string name)
            {
                _name = string.IsNullOrEmpty(name) ? "НЕИЗВЕСТНО" : name;
                return this;
            }

            public Builder WithPhoneNumber(string phoneNumber)
            {
                _phoneNumber = string.IsNullOrEmpty(phoneNumber) ? "НЕИЗВЕСТНО" : phoneNumber;
                return this;
            }

            public Builder WithAddress(string address)
            {
                _address = string.IsNullOrEmpty(address) ? "НЕИЗВЕСТНО" : address;
                return this;
            }

            public Reader Build()
            {
                return new Reader
                {
                    Name = _name,
                    PhoneNumber = _phoneNumber,
                    Address = _address
                };
            }
        }
    }
}
