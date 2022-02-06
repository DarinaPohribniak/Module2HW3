using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public abstract class Sweets
    {
        public Sweets(string name, decimal price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public string Name { get; }
        public decimal Price { get; }
        public double Weight { get; }
    }
}
