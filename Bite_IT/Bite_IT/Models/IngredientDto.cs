using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateIngredientDto
    {
        [Required]
        public ProductName productName { get; set; }
        [Required]
        public ProductType productType { get; set; }
        [Required]
        public float Quantity { get; set; }
    }

    public class UpdateIngredientDto : CreateIngredientDto
    {
        public ICollection<Meal> Meals { get; set; }
    }
    public class IngredientDto : CreateIngredientDto
    {
        [Required]
        public int Id { get; set; }
        public ICollection<Meal> Meals { get; set; }
    }
}