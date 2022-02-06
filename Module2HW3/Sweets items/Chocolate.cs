using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Chocolate : Candys
    {
        public Chocolate(
            string name, decimal price, double weight, string degreeOfSweetness, string cocoaContent)
                    : base(name, price, weight, degreeOfSweetness)
        {
            CocoaContent = cocoaContent;
        }

        public string CocoaContent { get; }
    }
}
