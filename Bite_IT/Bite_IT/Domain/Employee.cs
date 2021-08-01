using System;
using Microsoft.AspNetCore.Identity;

namespace Bite_IT.Domain
{
    public class Employee : IdentityUser
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDateTime { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public RoleType Role { get; set; }
        
    }
}