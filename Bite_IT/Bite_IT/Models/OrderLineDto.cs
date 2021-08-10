using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateOrderLineDto
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int MealId{ get; set; }
    }
    public class UpdateOrderLineDto : CreateOrderLineDto 
    {

        /*public Order Order { get; set; }
        public Meal Meal { get; set; }*/
    }
    public class OrderLineDto : CreateOrderLineDto
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Meal Meal { get; set; }
    }
}