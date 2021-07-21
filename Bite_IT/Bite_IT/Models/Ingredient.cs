using System.Collections.Generic;

namespace DefaultNamespace
{
    public class Ingredient
    {
        public ICollection<Meal> Meals { get; set; }
    }
}