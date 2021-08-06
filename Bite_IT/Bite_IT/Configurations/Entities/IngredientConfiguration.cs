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
                    Id = 1, ProductName = ProductName.Beef.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 2, ProductName = ProductName.Beetroot.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 3, ProductName = ProductName.Carrot.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 4, ProductName = ProductName.Fries.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 5, ProductName = ProductName.Mushroom.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 6, ProductName = ProductName.Orange.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 7, ProductName = ProductName.Pasta.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 8, ProductName = ProductName.Peppers.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 9, ProductName = ProductName.Pork.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 10, ProductName = ProductName.Potato.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 11, ProductName = ProductName.Rice.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 12, ProductName = ProductName.Schnitzel.ToString(), Quantity = 2
                },
                new Ingredient
                {
                    Id = 13, ProductName = ProductName.Tomato.ToString(), Quantity = 2
                }
            );
        }
    }
}