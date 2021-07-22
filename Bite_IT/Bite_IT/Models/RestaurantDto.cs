using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bite_IT.Models
{
    public class CreateRestaurantDto
    {
        [Required]
        [MinLength(1, ErrorMessage = "Restaurant name must be at lest 1 character long.")]
        [MaxLength(32, ErrorMessage = "Restaurant name must not be exceed 32 characters in length")]
        public string Name { get; private set; }
        [Required]
        [MinLength(10, ErrorMessage = "Restaurant address must be at lest 10 character long.")]
        [MaxLength(100, ErrorMessage = "Restaurant address must not be exceed 100 characters in length")]
        public string Address { get; private set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; private set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; private set; }
    }

    public class UpdateRestaurantDto : CreateRestaurantDto
    {
        public IList<EmployeeDto> Employees { get; private set; }
        public IList<StockDto> Stocks { get; private set; }
        public IList<OrderDto> Orders { get; private set; }
        public MenuDto Menu { get; private set; }
    }
    
    public class RestaurantDto : CreateRestaurantDto
    {
        public int Id { get; private set; }
        public IList<EmployeeDto> Employees { get; private set; }
        public IList<StockDto> Stocks { get; private set; }
        public IList<OrderDto> Orders { get; private set; }
        public MenuDto Menu { get; private set; }
    }
}