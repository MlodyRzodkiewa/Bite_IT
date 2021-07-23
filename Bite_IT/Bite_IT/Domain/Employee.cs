using System;

namespace Bite_IT.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Role { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public DateTime BirthDateTime { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        
    }
}