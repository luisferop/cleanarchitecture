﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public ICollection<Product> Products { get; private set; }
    }
}
