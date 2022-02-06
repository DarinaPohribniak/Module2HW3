using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Candys : Sweets
    {
        public Candys(string name, decimal price, double weight, string degreeOfSweetness)
            : base(name, price, weight)
        {
            DegreeOfSweetness = degreeOfSweetness;
        }

        public string DegreeOfSweetness { get; }
    }
}
