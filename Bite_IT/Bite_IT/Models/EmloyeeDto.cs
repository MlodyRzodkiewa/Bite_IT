using System;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateEmployeeDto
    {
        [Required]
        public String Login { get; set; }
        [Required]
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [Required]
        public int Role { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        public DateTime BirthDateTime { get; set; }
        public int RestaurantId { get; set; }
    }

    public class UpdateEmployeeDto : CreateEmployeeDto
    {
        public RestaurantDto Restaurant { get; set; }
    }
    
    public class EmloyeeDto : CreateOrderDto
    {
        [Required]
        public int Id { get; set; }
    }
}