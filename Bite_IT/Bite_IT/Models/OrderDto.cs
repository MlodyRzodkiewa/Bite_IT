using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateOrderDto
    {
        [Required]
        public int TableNumber { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
    }
    
    public class UpdateOrderDto : CreateOrderDto
    {
        public List<OrderLine> OrderLines { get; set; }
    }

    public class OrderDto : CreateOrderDto
    {
        [Required] 
        public int Id { get; set; }
        [Required]
        public RestaurantDto Restaurant { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        

    }
}