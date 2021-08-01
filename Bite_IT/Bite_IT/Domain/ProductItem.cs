using System;
using System.ComponentModel.DataAnnotations.Schema;
using Bite_IT.Models;

namespace Bite_IT.Domain
{
    public class ProductItem : Product
    {
       public DateTime ExpirationDate { get; set; }
       
       [ForeignKey(nameof(ProductInStock))]
       public int ProductInStockId { get; set; }
       public ProductInStock ProductInStock { get; private set; }
    }
}