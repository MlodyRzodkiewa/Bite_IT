namespace Bite_IT.Domain
{
    public class MealsIngredients
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}