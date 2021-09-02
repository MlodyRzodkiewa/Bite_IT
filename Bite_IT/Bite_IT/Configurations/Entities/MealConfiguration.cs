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
                    PromotionType = PromotionType.MealOfTheDay, FilterMarkers = new List<string>
                    {
                        MealType.GlutenFree.ToString(),
                        MealType.LactoseFree.ToString(),
                        MealType.Vegetarian.ToString(),
                    }
                },
                new Meal
                {
                    Id = 2, MenuId = 1, Description = "Spaghetti bolognese",
                    Price = 48, Name = "Spaghetti bolognese", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.LactoseFree.ToString(),
                    }
                },
                new Meal
                {
                    Id = 3, MenuId = 1, Description = "Sok pomarańczowy",
                    Price = 12, Name = "Sok wyciskany ze świeżych pomarańczy", MealType = MealType.Drink, 
                    PromotionType = PromotionType.MealOfTheDay
                },
                new Meal
                {
                    Id = 4, MenuId = 1, Description = "Szarlotka",
                    Price = 15, Name = "Szarlotka z lodami i bitą śmietaną", MealType = MealType.Dessert, 
                    PromotionType = PromotionType.Regular
                },
                new Meal
                {
                    Id = 5, MenuId = 1, Description = "Gnocchi z boczkiem",
                    Price = 38, Name = "Gnocchi z boczkiem", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.Regular
                },
                new Meal
                {
                    Id = 6, MenuId = 1, Description = "Lemoniada miętowa",
                    Price = 12, Name = "Lemoniada miętowa", MealType = MealType.Drink, 
                    PromotionType = PromotionType.Regular
                },
                new Meal
                {
                    Id = 7, MenuId = 1, Description = "Tiramisu",
                    Price = 19, Name = "Tiramisu", MealType = MealType.Dessert, 
                    PromotionType = PromotionType.Regular
                },
                new Meal
                {
                    Id = 8, MenuId = 1, Description = "Gazpacho",
                    Price = 14, Name = "Gazpacho", MealType = MealType.Soup, 
                    PromotionType = PromotionType.Regular
                },
                new Meal
                {
                    Id = 9, MenuId = 1, Description = "Zupa z domowej kiszonej kpusty na wywarze z wędzonych żeberk i boczku",
                    Price = 12, Name = "Kwaśnica", MealType = MealType.Soup, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.GlutenFree.ToString(),
                        MealType.LactoseFree.ToString(),
                    }
                },
                new Meal
                {
                    Id = 10, MenuId = 1, Description = "Pikantna zupa na mięsie wołowym",
                    Price = 16, Name = "Zupa gulaszowa", MealType = MealType.Soup, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string> { }
                },
                new Meal
                {
                    Id = 11, MenuId = 1, Description = "Placek drożdżowy z sezonowym owocem",
                    Price = 10, Name = "Miała baba placek", MealType = MealType.Dessert, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.GlutenFree.ToString(),
                        MealType.Vegetarian.ToString()
                    }
                },
                new Meal
                {
                    Id = 12, MenuId = 1, Description = "Placek kokosowo-czekoladowy z żurawiną i kokosem",
                    Price = 15, Name = "Murzynek", MealType = MealType.Dessert, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.GlutenFree.ToString(),
                        MealType.LactoseFree.ToString(),
                        MealType.Vegetarian.ToString(),
                    }
                },
                new Meal
                {
                    Id = 13, MenuId = 1, Description = "Coca-Cola z lodem",
                    Price = 5, Name = "Coca-Cola", MealType = MealType.Drink, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.GlutenFree.ToString(),
                        MealType.LactoseFree.ToString(),
                        MealType.Vegetarian.ToString(),
                    }
                },
                new Meal
                {
                    Id = 14, MenuId = 1, Description = "Herbata w różnych smakach: czarna, zielona, biała, owocowa",
                    Price = 7, Name = "Herbata", MealType = MealType.Drink, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.GlutenFree.ToString(),
                        MealType.LactoseFree.ToString(),
                        MealType.Vegetarian.ToString(),
                    }
                },
                new Meal
                {
                    Id = 15, MenuId = 1, Description = "Placek ziemniaczany z gulaszem wołowym",
                    Price = 27, Name = "Jadło drwala", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.GlutenFree.ToString(),
                        MealType.LactoseFree.ToString(),
                    }
                },
                new Meal
                {
                    Id = 16, MenuId = 1, Description = "Naleśniki z białym serem, owocami lub czekoladą",
                    Price = 8, Name = "Naleśniki", MealType = MealType.MainDish, 
                    PromotionType = PromotionType.Regular, FilterMarkers = new List<string>
                    {
                        MealType.Vegetarian.ToString(),
                    }
                }

            );
        }
        
    }
}