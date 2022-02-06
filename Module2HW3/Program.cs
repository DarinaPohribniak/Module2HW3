using System;
using System.Collections;

namespace Module2HW3
{
    public class Program
    {
        public Sweets[] Sweets { get; set; }

        public static void Main(string[] args)
        {
            // create sweets
            Lollipops[] sweets = new Lollipops[4];
            sweets[0] = new BeverageFlavored("Surprise candy", 10, 15d, "hight", "red", "no", "rom");
            sweets[1] = new BeverageFlavored("Crazy candy", 22, 23d, "hight", "blue", "no", "vine");
            sweets[2] = new Fruit("Jive", 18, 26d, "hight", "yellow", "no", "apple");
            sweets[3] = new Fruit("Samba", 14, 16d, "middle", "pink", "no", "kiwi");

            // add sweets in gift
            Gift gift = new Gift(sweets);
            Console.WriteLine("Gift composition:");
            foreach (var item in sweets)
            {
               item.Print();
            }

            // count weight of gift
            Console.WriteLine();
            gift.GetTotaltWeight();

            // Sort by name of sweets in the gift
            Console.WriteLine();
            Console.WriteLine("Sort result by name: ");
            gift.Sort(sweets);

            // Search for sweets by color in a gift with the implementation of the extension method
            Console.WriteLine();
            Console.WriteLine("Search result by color: ");
            sweets.IsCandyColor("red");

            Console.ReadLine();
        }
    }
}
