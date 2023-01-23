using MealBook.Domain.Interface;
using MealBook.Domain.Model;

namespace MealBook.Infrastructure.Repository
{
    public class MealRepository : IMealRepository
    {
        private readonly Context _context;

        public MealRepository(Context context)
        {
            _context = context;
        }

        public int AddMeal(Meal meal)
        {
            _context.Meals.Add(meal);
            _context.SaveChanges();

            return meal.Id;
        }

        public void RemoveMeal(int id)
        {
            var meal = _context.Meals.FirstOrDefault(p => p.Id == id);

            if(meal != null)
            {
                _context.Meals.Remove(meal);
                _context.SaveChanges();
            }            
        }

        public void UpdateMeal(Meal meal)
        {
            _context.Meals.Update(meal);
            _context.SaveChanges();
        }

        public IQueryable<Meal> ListMeals()
        {
            var meals = _context.Meals;
            return meals;
        }

        public Meal GetMealById(int id)
        {
            return _context.Meals.FirstOrDefault(m => m.Id == id);
        }

    }
}
