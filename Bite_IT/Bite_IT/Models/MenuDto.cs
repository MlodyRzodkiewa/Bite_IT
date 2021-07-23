using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateMenuDto
    {
        public List<Meal> Meals { get; set; }
        public int RestaurantId { get; set; }
    }

    public class UpdateMenuDto : CreateMenuDto
    {
        public Restaurant Restaurant { get; set; }
    }
        
    public class MenuDto : CreateMenuDto
    {
        [Required]
        public int Id { get; set; }
    }
    
}