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
    /// Таблица для хранения данных о жанрах
    /// </summary>
    [Table("Genres")]
    class GenreDb
    {
        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        [Key]
        public long ID { get; set; }
        /// <summary>
        /// Название жанра
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
