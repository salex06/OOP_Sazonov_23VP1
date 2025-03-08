using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.model.orm
{
    /// <summary>
    /// Таблица для хранения данных о читателях
    /// </summary>
    [Table("Readers")]
    class ReaderDb
    {
        /// <summary>
        /// Идентфикатор читателя
        /// </summary>
        [Key]
        public long ID { get; set; }
        /// <summary>
        /// ФИО читателя
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Номер телефона читателя
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Адрес проживания читателя
        /// </summary>
        [Required]
        public string Address { get; set; }
    }
}
