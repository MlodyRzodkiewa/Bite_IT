using System.Collections.Generic;

namespace Bite_IT.Domain
{
    public class Ingredient : Product
    {
        //public ICollection<Meal> Meals { get; set; }
        public ICollection<MealsIngredient> MealsIngredients { get; set; }
    }
}