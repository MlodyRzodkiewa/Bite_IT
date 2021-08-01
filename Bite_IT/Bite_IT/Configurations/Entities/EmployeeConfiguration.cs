
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bite_IT.Domain;

namespace Bite_IT.Configurations.Entities
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee {Id = 1, UserName = "akowalski", PasswordHash = "12345", FirstName = "Adam",
                LastName = "Kowalski", Role = RoleType.Cook, PhoneNumber = "123456789", Email = "akowalski@gmail.com"
                },
                new Employee {Id = 2, UserName = "knowak", PasswordHash = "abcde", FirstName = "Karol",
                        LastName = "Nowak", Role = RoleType.Waiter, PhoneNumber = "123456789", Email = "knowak@gmail.com"
                }
                );
        }
    }
}