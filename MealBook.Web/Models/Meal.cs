namespace MealBook.Web.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Cook Author { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }        
    }
}
