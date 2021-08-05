using System;
using System.Collections.Generic;
using System.Data.Common;
using Bite_IT.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bite_IT.Configurations.Entities
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(
                new Ingredient
                {
                    Id = 1, productName = ProductName.Beef, Quantity = 2
                },
                new Ingredient
                {
                    Id = 2, productName = ProductName.Beetroot, Quantity = 2
                },
                new Ingredient
                {
                    Id = 3, productName = ProductName.Carrot, Quantity = 2
                },
                new Ingredient
                {
                    Id = 4, productName = ProductName.Fries, Quantity = 2
                },
                new Ingredient
                {
                    Id = 5, productName = ProductName.Mushroom, Quantity = 2
                },
                new Ingredient
                {
                    Id = 6, productName = ProductName.Orange, Quantity = 2
                },
                new Ingredient
                {
                    Id = 7, productName = ProductName.Pasta, Quantity = 2
                },
                new Ingredient
                {
                    Id = 8, productName = ProductName.Peppers, Quantity = 2
                },
                new Ingredient
                {
                    Id = 9, productName = ProductName.Pork, Quantity = 2
                },
                new Ingredient
                {
                    Id = 10, productName = ProductName.Potato, Quantity = 2
                },
                new Ingredient
                {
                    Id = 11, productName = ProductName.Rice, Quantity = 2
                },
                new Ingredient
                {
                    Id = 12, productName = ProductName.Schnitzel, Quantity = 2
                },
                new Ingredient
                {
                    Id = 13, productName = ProductName.Tomato, Quantity = 2
                }
            );
        }
    }
}