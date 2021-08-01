using System;
using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bite_IT.Configurations.Entities
{
    public class ProductItemConfiguration : IEntityTypeConfiguration<ProductItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductItem> builder)
        {
            builder.HasData(
                new ProductItem {Id = 1, ProductInStockId = 1, ExpirationDate = new DateTime(2021-10-01), Quantity = 2},
                new ProductItem {Id = 2, ProductInStockId = 2, ExpirationDate = new DateTime(2021-12-01),Quantity = 1}
            );
        }
    }
}