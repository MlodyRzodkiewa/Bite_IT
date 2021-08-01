using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bite_IT.Configurations.Entities
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                new Restaurant
                {
                    Id = 1, Name = "Włoski smak", Address = "ul.Kolejowa 2", PhoneNumber = "123456789",
                    Email = "wloskismak@gmail.com",
                }
            );
        }
    }
}