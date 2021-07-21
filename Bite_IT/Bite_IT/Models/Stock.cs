using System;
using System.Collections.Generic;

namespace Bite_IT.Models
{
    public class Stock
    {
        public Guid Id { get; }
        public string Name { get; private set; }

        public List<ProductInStock> Products { get; private set; } = new();
        
        public Guid RestaurantId { get; private set; }
        public Restaurant Restaurant { get; private set; }

        public Stock(string name, Restaurant restaurant)
        {
            Id = Guid.NewGuid();
            Name = name;
            RestaurantId = restaurant.Id;
            Restaurant = restaurant;
        }
    }
}