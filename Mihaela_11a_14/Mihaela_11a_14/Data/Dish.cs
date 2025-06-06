﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihaela_11a_14.Data
{
    public  class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }
        public int DishTypeId { get; set; }
        public DishType DishTypes { get; set; }
    }
}
