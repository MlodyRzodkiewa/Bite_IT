using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Bite_IT.Models;
using Microsoft.Extensions.Azure;
using Microsoft.VisualBasic;

namespace Bite_IT.Domain
{
    public class ProductInStock : Product
    {
        public IList<ProductItem> ProductItems { get; private set; }
        
        [ForeignKey(nameof(Stock))]
        public int StockId { get; set; }
        public Stock Stock { get; private set; }
    }
}