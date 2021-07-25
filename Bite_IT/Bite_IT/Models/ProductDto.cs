using Bite_IT.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bite_IT.Models
{
    public class ProductDto
    {
        [Required]
        public int Id { get; set; }

    }
    public class CreateProductDto : ProductDto
    {
        [Required]
        public ProductName productName { get; set; }
        [Required]
        public ProductType productType { get; set; }
        [Required]
        public float Quantity { get; set; }
    }
}
