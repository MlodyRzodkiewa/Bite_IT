using System.Collections.Generic;

namespace Bite_IT.Domain
{
    public class Ingredient
    {
        public ICollection<Meal> Meals { get; set; }
    }
}