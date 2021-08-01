using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using Bite_IT.Models;

namespace Bite_IT.Domain
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public IList<Employee> Employees { get; private set; }
        
        public IList<Stock> Stocks { get; private set; }

        public IList<Order> Orders { get; private set; }
        
        public Menu Menu { get; private set; }

        // public Restaurant(int id, string name, string address)
        // {
        //     Id = id;
        //     Name = name;
        //     Address = address;
        //     Employees = new List<Employee>();
        //     Stocks = new List<Stock>();
        //     Orders = new List<Order>();
        // }
    }
}