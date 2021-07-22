using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Azure;
using Microsoft.VisualBasic;

namespace Bite_IT.Domain
{
    public class ProductInStock : Product
    {
        public IList<ProductItem> ProductItems { get; private set; }
        
        [ForeignKey(nameof(Stock))]
        public int StockId { get; private set; }
        public Stock Stock { get; private set; }

        public ProductInStock(ProductName productName, ProductType productType, Stock stock) : 
            base(productName, productType, 0f)
        {
            ProductItems = new List<ProductItem>();
            StockId = stock.Id;
            Stock = stock;
        }
    }
}