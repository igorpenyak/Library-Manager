﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Entities
{
    public class BookInfo
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
        public string Publisher { get; set; }
    }
}
