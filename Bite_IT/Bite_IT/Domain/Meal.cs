using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace Bite_IT.Domain
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MealType MealType { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        // public PromotionType PromotionType { get; set; }
        [ForeignKey(nameof(Menu))]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}