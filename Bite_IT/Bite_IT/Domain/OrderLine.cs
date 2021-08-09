namespace Bite_IT.Domain
{
    public class OrderLine
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}