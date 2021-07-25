using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bite_IT.Domain;

namespace Bite_IT.Models
{
    public class CreateProductInStockDto// : CreateProductDto
    {
        [Required]
        public int StockId { get; set; }
    }

    public class UpdateProductInStockDto : CreateProductInStockDto
    {
        public IList<ProductItemDto> ProductItems { get; set; }
        public StockDto Stock { get; set; }
    }

    public class ProductInStockDto : CreateProductInStockDto
    {
        [Required]
        public int Id { get; set; }
        public IList<ProductItemDto> ProductItems { get; set; }
        public StockDto Stock { get; set; }
    }
}