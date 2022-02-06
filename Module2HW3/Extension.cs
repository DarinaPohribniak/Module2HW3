using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public static class Extension
    {
        public static void IsCandyColor(this Lollipops[] sweets, string color)
        {
            for (int i = 0; i < sweets.Length; i++)
            {
                if (sweets[i].Color == color)
                {
                    sweets[i].Print();
                    break;
                }
                else
                {
                    Console.WriteLine($"Sweet with specified color {color} is not found.");
                }
            }
        }

        public static void Print(this Lollipops sweets)
        {
            Console.WriteLine($"Sweet: {sweets.Name}; price: {sweets.Price} UAH; " +
                                    $"weight: {sweets.Weight} g.; degreeOfSweetness: {sweets.DegreeOfSweetness}; " +
                                    $"color: {sweets.Color}.");
        }
    }
}