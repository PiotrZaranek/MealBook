using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBook.Domain.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Unit { get; set; }

        // n:m To MealIngredient
        public ICollection<MealIngredniet> MealIngredniet { get; set; }
    }
}
