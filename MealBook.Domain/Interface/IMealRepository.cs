using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealBook.Domain.Model;
using Microsoft.VisualBasic.FileIO;

namespace MealBook.Domain.Interface
{
    public interface IMealRepository
    {
        int AddMeal(Meal meal);
        void RemoveMeal(int id);
        void UpdateMeal(Meal meal);
        IQueryable<Meal> ListMeals();
        Meal GetMealById(int id);
    }
}
