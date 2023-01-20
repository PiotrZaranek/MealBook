using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBook.Domain.Model
{
    public class MealDetalInformation
    {
        public int Id { get; set; }
        public int Time { get; set; }
        public string Diffculty { get; set; }

        // 1:1 To Meal
        public Meal Meal { get; set; }
    }
}
