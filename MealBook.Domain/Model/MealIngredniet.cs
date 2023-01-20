using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBook.Domain.Model
{
    public class MealIngredniet
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
