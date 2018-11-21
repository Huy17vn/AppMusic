﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public List<SongCategory> SongCategories { get; set; }
    }
}
