﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP_Sazonov_23VP1.dto
{
    /// <summary>
    /// DTO для передачи информации о фильтрах
    /// для поиска читателей
    /// </summary>
    public class ReaderFilterOptions
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool? isDebtor { get; set; }
    }
}
