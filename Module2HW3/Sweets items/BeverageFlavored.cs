using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class BeverageFlavored : Ordinary
    {
        public BeverageFlavored(
            string name, decimal price, double weight, string degreeOfSweetness, string color, string filling, string theTasteOfTheDrink)
            : base(
                  name, price, weight, degreeOfSweetness, color, filling)
        {
            TheTasteOfTheDrink = theTasteOfTheDrink;
        }

        public string TheTasteOfTheDrink { get; }
    }
}
