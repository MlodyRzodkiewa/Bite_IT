using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bite_IT.Domain
{
    public class ProductItem : Product
    {
       public DateTime ExpirationDate { get; private set; }
       
       [ForeignKey(nameof(ProductInStock))]
       public int ProductInStockId { get; private set; }
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