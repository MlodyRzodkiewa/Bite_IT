using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace DefaultNamespace
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public MealType MealType { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public PromotionType PromotionType { get; set; }
        public Guid MenuId { get; set; }
        //public Menu Menu { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        //public ICollection<Order> Orders { get; set; }
    }
}