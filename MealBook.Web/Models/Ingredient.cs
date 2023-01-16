using Microsoft.AspNetCore.Authorization;

namespace MealBook.Web.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }


        public double Glass { get; set; }
        public double Tablespoon { get; set; }
        public double Spoon { get; set; }
    }
}
