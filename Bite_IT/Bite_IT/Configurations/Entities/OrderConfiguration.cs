using System;
using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bite_IT.Configurations.Entities
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    Id = 1, RestaurantId = 1, CreationDate = new DateTime(2021 - 07 - 25),
                },
                new Order
                {
                    Id = 1, RestaurantId = 1, CreationDate = new DateTime(2021 - 07 - 26),
                }
            );
        }
    }
}