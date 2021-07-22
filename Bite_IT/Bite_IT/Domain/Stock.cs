using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bite_IT.Domain
{
    public class Stock
    {
        public int Id { get; }
        public string Name { get; private set; }

        public IList<ProductInStock> Products { get; private set; }
        [ForeignKey(nameof(Restaurant))]
        
        public int RestaurantId { get; private set; }
        public Restaurant Restaurant { get; private set; }

        public Stock(int id, string name, Restaurant restaurant)
        {
            Id = id;
            Name = name;
            Products = new List<ProductInStock>();
            RestaurantId = restaurant.Id;
            Restaurant = restaurant;
        }
    }
}