using System;

namespace Bite_IT.Models
{
    public class ProductItem : Product
    {
       public DateTime ExpirationDate { get; private set; } 
       
       public Guid ProductInStockId { get; private set; }
       public ProductInStock ProductInStock { get; private set; }

       public ProductItem(ProductName productName, ProductType productType, float quantity, ProductInStock productInStock, 
           DateTime expirationDate) : base(productName, productType, quantity)
       {
           ExpirationDate = expirationDate;
           ProductInStockId = productInStock.Id;
           ProductInStock = productInStock;
       }
    }
}