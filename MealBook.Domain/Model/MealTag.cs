﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBook.Domain.Model
{
    public class MealTag
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
