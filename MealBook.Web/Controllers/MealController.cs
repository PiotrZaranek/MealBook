using MealBook.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealBook.Web.Controllers
{
    public class MealController : Controller
    {
        public IActionResult Muffin()
        {
            Meal muffin = new Meal();
            Cook cook = new Cook() { Id = 1, Name = "Adam" };
            List<Ingredient> ingrdient = new List<Ingredient>();

            ingrdient.Add(new Ingredient() { Name = "Mąka pszenna", Quantity = 300, Unit = "g" });
            ingrdient.Add(new Ingredient() { Name = "Cukier", Quantity = 100, Unit = "g" });
            ingrdient.Add(new Ingredient() { Name = "Cukier waniliowy", Quantity = 30, Unit = "g" });
            ingrdient.Add(new Ingredient() { Name = "Jajka", Quantity = 2 , Unit = "sztuki" });
            ingrdient.Add(new Ingredient() { Name = "Mleko", Quantity = 150, Unit = "ml" });
            ingrdient.Add(new Ingredient() { Name = "Olej", Quantity = 100, Unit = "ml"});
            ingrdient.Add(new Ingredient() { Name = "Czekolada", Quantity = 100, Unit = "g" });

            muffin.Author = cook;
            muffin.Ingredients = ingrdient;
            muffin.Id = 1;
            muffin.Time = 15;
            muffin.Name = "Muffinki czekoladowe";
            muffin.Description = "W jednej misce wymieszać mąkę, cukier, cukier waniliowy i proszek do pieczenia. W drugiej misce wymieszać trzepaczką gazowaną wodę mineralną, olej i jajka. Następnie wymieszać trzepaczką składniki z obu misek. Nie mieszać długo, lecz tylko do momentu połączenia się składników. Na końcu wmieszać delikatnie szpatułką kawałki czekolady. Formę na muffinki wyłożyć papilotkami. Ciasto nałożyć do papilotek. Muffinki piec w nagrzanym piekarniku ok. 30 minut, do suchego patyczka, w temperaturze 180°C (grzałka góra- dół). Studzić przez parę minut przy uchylonych drzwiczkach piekarnika. Następnie wyciągnąć na kratkę i pozostawić do całkowitego ostygnięcia.";

            return View(muffin);
        }

        public IActionResult Spaghetti()
        {
            Meal spaghetti = new Meal();
            Cook cook = new Cook() { Id = 1, Name = "Aleksandra" };
            List<Ingredient> ingredient = new List<Ingredient>();

            ingredient.Add(new Ingredient() { Name = "Boczek", Quantity = 150, Unit = "g" });
            ingredient.Add(new Ingredient() { Name = "Cebula", Quantity = 1, Unit = "sztuka" });
            ingredient.Add(new Ingredient() { Name = "Makaron spaghetti", Quantity = 300, Unit = "g" });
            ingredient.Add(new Ingredient() { Name = "Jajka", Quantity = 3 , Unit = "sztuki" });
            ingredient.Add(new Ingredient() { Name = "Ser Grana Padano", Quantity = 100, Unit = "g" });

            spaghetti.Author = cook;
            spaghetti.Ingredients = ingredient;
            spaghetti.Id = 1;
            spaghetti.Time = 30;
            spaghetti.Name = "Sphagetti Carbonara";
            spaghetti.Description = "Spaghetti ugotuj al dente, po ugotowaniu odcedź, zachowaj jednak pół szklanki wody, w której gotował się makaron. Boczek pokrój w cienkie paseczki. Jajka rozbełtaj, wymieszaj z pecorino i parmezanem oraz odrobiną soli i pieprzu. Na rozgrzaną patelnię (średni ogień) wrzuć boczek, po kilku minutach, gdy mocno się zarumieni, dodaj makaron i wodę, która została po gotowaniu makaronu. Podgrzewaj całość kilka minut. Ściągnij patelnię z ognia, dodaj masę jajeczną, mieszaj szybko tak, aby jajka nie ścięły się na jajecznicę. Makaron przełóż na talerze (choć można jeść go też prosto z patelni). Podawaj z pietruszką.";

            return View(spaghetti);
        }   
        
        public IActionResult Waffle()
        {
            Meal waffle = new Meal();
            Cook cook = new Cook() { Id = 1, Name = "Piotr"};
            List<Ingredient> ingredient = new List<Ingredient>();

            ingredient.Add(new Ingredient() { Name = "Mąka pszenna", Quantity = 300 , Unit = "g" });
            ingredient.Add(new Ingredient() { Name = "Mleko", Quantity = 250 , Unit = "ml" });
            ingredient.Add(new Ingredient() { Name = "Woda", Quantity = 250 , Unit = "ml" });
            ingredient.Add(new Ingredient() { Name = "Olej", Quantity = 100, Unit = "ml" });
            ingredient.Add(new Ingredient() { Name = "Jajka", Quantity = 2, Unit = "sztuki" });

            waffle.Author = cook;
            waffle.Ingredients = ingredient;
            waffle.Id = 1;
            waffle.Time = 60;
            waffle.Name = "Gofry";
            waffle.Description = "Białka oddziel od żółtek. Do większej miski z żółtkami przelej mleko, wodę oraz olej. Mąkę przesiej z proszkiem do pieczenia, zmiksuj. Białka ubij na sztywno z cukrami i szczyptą soli. Sztywną pianę z białek przełoż do miski i wymieszaj delikatnie do połączenia składników. Gofry zawsze piecz na maksymalnie rozgrzanej gofrownicy do zrumienienia. Gotowe gofry przekładaj na kratkę, by odparowały i jak najdłużej były chrupiące.";

            return View(waffle);
        }
    }
}
