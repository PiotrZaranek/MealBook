using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealBook.Domain.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // n:m To MealTag
        public ICollection<MealTag> MealTag { get; set; }
    }
}
