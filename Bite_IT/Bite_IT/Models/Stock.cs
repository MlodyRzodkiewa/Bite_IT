using System;
using System.Collections.Generic;

namespace Bite_IT.Models
{
    public class Stock
    {
        public int Id { get; }
        public string Name { get; private set; }

        public List<ProductInStock> Products { get; private set; } = new();
        
        public int RestaurantId { get; private set; }
        public Restaurant Restaurant { get; private set; }

        public Stock(int id, string name, Restaurant restaurant)
        {
            Id = id;
            Name = name;
            RestaurantId = restaurant.Id;
            Restaurant = restaurant;
        }
    }
}