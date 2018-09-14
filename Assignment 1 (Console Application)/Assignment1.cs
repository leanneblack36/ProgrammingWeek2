using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1__Console_Application_
{
    class Program
    {
       const double VAT = 0.21;

        static void Main(string[] args)
        {
            // Enter a price. Determine the VAT (21%) on this price. Print the price, VAT, and the price + VAT.

            // ask console for users price 
            Console.Write("Enter a price: ");
            string input = Console.ReadLine();
            // change the input from a string to a number
            Double price = Double.Parse(input);

            //calculations for the price//
            Double tax = price * VAT;
            Double totalprice = price + tax;

            Console.WriteLine("price: {0}, VAT: {1}, total: {2}", price, tax, totalprice);

            Console.ReadKey();

        }
    }
}
