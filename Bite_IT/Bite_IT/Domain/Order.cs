using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bite_IT.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public TableNumber TableNumber { get; set; }
        public List<Meal> Meals { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}