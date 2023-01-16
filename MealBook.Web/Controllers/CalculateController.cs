using Microsoft.AspNetCore.Mvc;
using MealBook.Web.Models;    

namespace MealBook.Web.Controllers
{
    public class CalculateController : Controller
    {
        private List<Ingredient> ingredients;

        public CalculateController()
        {
            ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { Name = "Mąka pszenna", Glass = 170d, Tablespoon = 10.2d, Spoon = 3.4d});
            ingredients.Add(new Ingredient() { Name = "Mąka żytnia", Glass = 136d, Tablespoon = 8.1d, Spoon = 2.7d});
            ingredients.Add(new Ingredient() { Name = "Cukier kryształ", Glass = 220d, Tablespoon = 13.2d, Spoon = 4.4d});
            ingredients.Add(new Ingredient() { Name = "Cukier puder", Glass = 200d, Tablespoon = 12.0d, Spoon = 4.0d});
            ingredients.Add(new Ingredient() { Name = "Kakao", Glass = 125d, Tablespoon = 7.5d, Spoon = 2.5d});
        }

        public IActionResult Index(int id)
        {
            Ingredient ingredient;

            switch (id)
            {
                case 1:
                    {
                        ingredient = ingredients[0];
                        break;
                    }
                case 2:
                    {
                        ingredient = ingredients[1];
                        break;
                    }
                case 3:
                    {
                        ingredient = ingredients[2];
                        break;
                    }
                case 4:
                    {
                        ingredient = ingredients[3];
                        break;
                    }
                case 5:
                    {
                        ingredient = ingredients[4];
                        break;
                    }
                default:
                    {
                        ingredient = ingredients[0];
                        break;
                    }
            }

            return View(ingredient);
        }
    }
}
