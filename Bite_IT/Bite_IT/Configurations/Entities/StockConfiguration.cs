using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bite_IT.Configurations.Entities
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Stock> builder)
        {
            builder.HasData(
                new Stock{Id = 1, Name = "Magazyn", RestaurantId = 1}
                );
        }
        
    }
}