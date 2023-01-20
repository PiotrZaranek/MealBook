using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBook.Domain.Model
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Desctiption { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }

        // 1:1 To MealDetalInformation
        public int MealDetalInformationsId { get; set; }
        public MealDetalInformation MealDetalInformation { get; set; }

        // 1:1 To User
        public int UserId { get; set; }

        // n:m To MealTag
        public ICollection<MealTag> MealTag { get; set; }

        // n:m To MealIngredient
        public ICollection<MealIngredniet> MealIngredniet { get; set; }
    }
}
