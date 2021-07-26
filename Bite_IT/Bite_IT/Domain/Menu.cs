using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bite_IT.Domain
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Meal> Meals { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public Status Status { get; set; }
    }
}