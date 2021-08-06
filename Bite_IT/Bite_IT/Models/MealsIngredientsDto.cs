using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateMealsIngredientsDto
    {
        [Required]
        public int MealId { get; set; }
        [Required]
        public int IngredientId { get; set; }
    }

    public class UpdateMealsIngredientsDto : CreateMealsIngredientsDto
    {
        public Meal Meal { get; set; }
        public Ingredient Ingredient { get; set; }
    }
    
    public class MealsIngredientsDto : CreateMealsIngredientsDto
    {
        public Meal Meal { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}