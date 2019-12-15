using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public double Total()
        {
            return Price * Amount;
        }
    }
}
