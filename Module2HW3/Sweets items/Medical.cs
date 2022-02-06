using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Medical : Lollipops
    {
        public Medical(
            string name, decimal price, double weight, string degreeOfSweetness, string color, string activeSubstance)
             : base(name, price, weight, degreeOfSweetness, color)
        {
            ActiveSubstance = activeSubstance;
        }

        public string ActiveSubstance { get; }
        public string Diagnosis { get; }
    }
}
