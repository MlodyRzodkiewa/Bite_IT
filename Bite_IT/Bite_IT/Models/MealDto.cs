using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateMealDto
    {
        [Required]
        [StringLength(maximumLength: 64, ErrorMessage = "Meal name is too long!")]
        public string Name { get; set; }
        [Required]
        public MealType MealType { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [StringLength(maximumLength: 256, ErrorMessage = "Meal descripton is too long!")]
        public string Description { get; set; }
        [Required]
        public int MenuId { get; set; }
        public List<string> FilterMarkers { get; set; }
    }

    public class UpdateMealDto : CreateMealDto
    {
        public PromotionType PromotionType { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public Menu Menu { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
    
    public class MealDto : CreateMealDto
    {
        [Required]
        public int Id { get; set; }
        public PromotionType PromotionType { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public Menu Menu { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}