using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.dto
{
    public class BookFilterOptions
    {
        public string? Title { get; set; }
        public int? YearOfPublication { get; set; }
        public string? Publisher { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? ISBN { get; set; }
    }
}
