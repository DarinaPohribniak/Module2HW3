using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Cakes : Sweets
    {
        public Cakes(string name, decimal price, double weight, string form)
            : base(name, price, weight)
        {
            Form = form;
        }

        public string Form { get; }
    }
}
