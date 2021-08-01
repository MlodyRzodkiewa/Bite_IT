using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bite_IT.Configurations.Entities
{
    public class ProductInStockConfiguration : IEntityTypeConfiguration<ProductInStock>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductInStock> builder)
        {
            builder.HasData(
                new ProductInStock{Id = 1, StockId = 1, Quantity = 2},
                new ProductInStock{Id = 2, StockId = 1, Quantity = 3}
            );
        }
    }
}