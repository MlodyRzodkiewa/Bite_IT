using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bite_IT.Domain
{
    public abstract class Product
    {
        public int Id { get; set; }
        public ProductName productName { get; set; }
        //public ProductType productType { get; set; }
        public float Quantity { get; set; }
    }
}
