using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class Fruit : Ordinary
    {
        public Fruit(
            string name, decimal price, double weight, string degreeOfSweetness, string color, string filling, string fruitFlavor)
            : base(name, price, weight, degreeOfSweetness, color, filling)
        {
            FruitFlavor = fruitFlavor;
        }

        public string FruitFlavor { get; }
    }
}
