using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bite_IT.Domain;

namespace Bite_IT.Configurations.Entities
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu {Id = 1, RestaurantId = 1,},
                new Menu {Id = 2, RestaurantId = 2,}
            );
        }
    }
}