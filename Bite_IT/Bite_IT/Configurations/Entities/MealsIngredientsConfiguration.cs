using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bite_IT.Domain;

namespace Bite_IT.Configurations.Entities

{
    public class MealsIngredientsConfiguration : IEntityTypeConfiguration<MealsIngredient>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MealsIngredient> builder)
        {
            builder.HasData(
                new MealsIngredient { MealId = 1, IngredientId = 3 },
                new MealsIngredient { MealId = 1, IngredientId = 4 },
                new MealsIngredient { MealId = 1, IngredientId = 12 },
                new MealsIngredient { MealId = 2, IngredientId = 5 },
                new MealsIngredient { MealId = 2, IngredientId = 7 },
                new MealsIngredient { MealId = 2, IngredientId = 8 },
                new MealsIngredient { MealId = 2, IngredientId = 9 },
                new MealsIngredient { MealId = 2, IngredientId = 13 },
                new MealsIngredient { MealId = 3, IngredientId = 6 }
            );
        }
        
    }
}