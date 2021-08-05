using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bite_IT.Domain;

namespace Bite_IT.Configurations.Entities

{
    public class MealsIngredientsConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new MealsIngredients { MealId = 1, IngredientId = 3 },
                new MealsIngredients { MealId = 1, IngredientId = 4 },
                new MealsIngredients { MealId = 1, IngredientId = 12 },
                new MealsIngredients { MealId = 2, IngredientId = 5 },
                new MealsIngredients { MealId = 2, IngredientId = 7 },
                new MealsIngredients { MealId = 2, IngredientId = 8 },
                new MealsIngredients { MealId = 2, IngredientId = 9 },
                new MealsIngredients { MealId = 2, IngredientId = 13 },
                new MealsIngredients { MealId = 3, IngredientId = 6 }
            );
        }
        
    }
}