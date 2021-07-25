using Bite_IT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bite_IT.Models
{
    public class ProductDto
    {
        public int Id { get; set; }

    }
    public class CreateProductDto : ProductDto
    {
        public ProductName productName { get; set; }
        public ProductType productType { get; set; }
        public float Quantity { get; set; }
    }
}
