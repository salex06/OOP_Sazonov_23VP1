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
    /// Таблица для хранения данных об авторах
    /// </summary>
    [Table("Authors")]
    class AuthorDb
    {
        /// <summary>
        /// Идентификатор автора в базе данных
        /// </summary>
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Дата рождения автора
        /// </summary>
        [Required]
        public DateTime Birthday { get; set; }
    }
}
