using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Azure;
using Microsoft.VisualBasic;

namespace Bite_IT.Models
{
    public class ProductInStock : Product
    {
        public List<ProductItem> ProductItems { get; private set; } = new();
        public int StockId { get; private set; }
        public Stock Stock { get; private set; }

        public ProductInStock(ProductName productName, ProductType productType, float quantity, Stock stock) : 
            base(productName, productType, quantity)
        {
            StockId = stock.Id;
            Stock = stock;
        }
    }
}