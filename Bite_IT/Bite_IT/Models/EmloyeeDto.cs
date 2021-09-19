using System;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;
using Microsoft.AspNetCore.Authentication;

namespace Bite_IT.Models
{
    public class LoginEmployeeDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 5)]
        public string Password { get; set; }
    }

    public class RegisterEmployeeDto
    { 
        [Required] 
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        // [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        // [Required]
        public string BirthDateTime { get; set; }
        // [Required]
        public int Role { get; set; }
        
    }

}