using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Lollipops : Candys
    {
        public Lollipops(
            string name, decimal price, double weight, string degreeOfSweetness, string color)
            : base(name, price, weight, degreeOfSweetness)
        {
            Color = color;
        }

        public string Color { get; }
    }
}
