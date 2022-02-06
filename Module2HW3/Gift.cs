using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Gift : IGift
    {
        public Gift(Sweets[] sweets)
        {
            if (sweets == null)
            {
                sweets = new Sweets[0];
            }
            else
            {
                Sweets = sweets;
            }
        }

        private Sweets[] Sweets { get; set; }
        public void GetTotaltWeight()
        {
            double giftWeight = 0;
            foreach (var item in Sweets)
            {
                giftWeight = giftWeight + item.Weight;
            }

            Console.WriteLine($"Total weight of gift is {giftWeight} g.");
        }

        public void Sort(Lollipops[] sweets)
        {
            IEnumerable<Lollipops> query = sweets.OrderBy(sweets => sweets.Name);

            foreach (Lollipops candy in query)
            {
                candy.Print();
            }
        }
    }
}