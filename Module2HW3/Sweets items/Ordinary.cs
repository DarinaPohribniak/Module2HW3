using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Ordinary : Lollipops
    {
        public Ordinary(
            string name, decimal price, double weight, string degreeOfSweetness, string color, string filling)
            : base(name, price, weight, degreeOfSweetness, color)
        {
            Filling = filling;
        }

        public string Filling { get; }
    }
}
