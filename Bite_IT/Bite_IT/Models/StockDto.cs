using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Bite_IT.Models
{
    public class CreateStockDto
    {
        [Required]
        [MinLength(1, ErrorMessage = "Stock Name must be at list 1 character long")]
        [MaxLength(32, ErrorMessage = "Stock name must not be exceed 32 characters in length")]
        public string Name { get; private set; }
        public int RestaurantId { get; private set; }
    }

    public class UpdateStockDto : CreateStockDto
    {
        public IList<ProductInStockDto> Products { get; private set; }
        public RestaurantDto Restaurant { get; private set; }
    }
    public class StockDto
    {
        public int Id { get; private set; }
        public IList<ProductInStockDto> Products { get; private set; }
        public RestaurantDto Restaurant { get; private set; }
    }
}