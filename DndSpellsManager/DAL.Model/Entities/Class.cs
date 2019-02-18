﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SpellClass> Spells { get; set; }
    }
}
