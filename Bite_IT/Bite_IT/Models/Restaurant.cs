using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;

namespace Bite_IT.Models
{
    public class Restaurant
    {
        public int Id { get; }
        public string Name { get; private set; }
        public string Address { get; private set; }

        public List<Employee> Employees { get; private set; } = new();
        
        public List<Stock> Stocks { get; private set; } = new();

        public List<Order> Orders { get; private set; } = new();
        
        public Menu Menu { get; private set; } = new();

        public Restaurant(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}