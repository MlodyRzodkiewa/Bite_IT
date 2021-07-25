using System;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateProductItemDto// : ProductDto
    {
        [Required]
        public DateTime ExpirationDate { get; private set; }
        public int ProductInStockId { get; private set; }
    }

    public class UpdateProductItemDto : CreateProductItemDto
    {
        public ProductInStockDto ProductInStock { get; private set; }
    }

    public class ProductItemDto : CreateProductItemDto
    {
        public int Id { get; set; }
        public ProductInStockDto ProductInStock { get; private set; }
    }
}