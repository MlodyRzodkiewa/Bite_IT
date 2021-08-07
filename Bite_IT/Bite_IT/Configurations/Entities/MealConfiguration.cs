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
                    PromotionType = PromotionType.MealOfTheDay
                },
                new Meal
                {
                    Id = 2, MenuId = 1, Description = "Spaghetti bolognese",
                    Price = 48, Name = "Spaghetti bolognese", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.Regular
                },
                new Meal
                {
                    Id = 3, MenuId = 1, Description = "Sok pomarańczowy",
                    Price = 12, Name = "Sok wyciskany ze świeżych pomarańczy", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.MealOfTheDay
                }
            );
        }
        
    }
}