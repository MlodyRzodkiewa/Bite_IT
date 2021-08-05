using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bite_IT.Domain;

namespace Bite_IT.Configurations.Entities

{
    public class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal
                {
                    Id = 1, MenuId = 1, Description = "Zupa pomidorowa ze świeżych pomidorów z dodatkiem bazylii",
                    Price = 35, Name = "Zupa Pomidorowa", MealType = MealType.Soup, 
                    PromotionType = PromotionType.MealOfTheDay,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Id = 3, productName = ProductName.Carrot, Quantity = 2 },
                        new Ingredient { Id = 4, productName = ProductName.Fries, Quantity = 2 },
                        new Ingredient { Id = 12, productName = ProductName.Schnitzel, Quantity = 2 }
                    }
                },
                new Meal
                {
                    Id = 2, MenuId = 1, Description = "Spaghetti bolognese",
                    Price = 48, Name = "Spaghetti bolognese", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.Regular,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Id = 5, productName = ProductName.Mushroom, Quantity = 2 },
                        new Ingredient { Id = 7, productName = ProductName.Pasta, Quantity = 2 },
                        new Ingredient { Id = 8, productName = ProductName.Peppers, Quantity = 2 },
                        new Ingredient { Id = 9, productName = ProductName.Pork, Quantity = 2 },
                        new Ingredient { Id = 13, productName = ProductName.Tomato, Quantity = 2 }
                    }
                },
                new Meal
                {
                    Id = 3, MenuId = 1, Description = "Sok pomarańczowy",
                    Price = 12, Name = "Sok wyciskany ze świeżych pomarańczy", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.MealOfTheDay,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Id = 6, productName = ProductName.Orange, Quantity = 2 }
                    }
                }
            );
        }
        
    }
}