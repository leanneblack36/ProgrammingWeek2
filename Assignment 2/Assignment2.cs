using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter three numbers. Calculate the average value of these numbers. 
            //Print the average value. NB: Division results in a floating point number!

            Console.Write("Enter 1st number: ");
            string input1 = Console.ReadLine();
            Double firstnumber = Double.Parse(input1);


            Console.Write("Enter 2nd number: ");
            string input2 = Console.ReadLine();
            Double secondnumber = Double.Parse(input2);


            Console.Write("Enter 3rd number: ");
            string input3 = Console.ReadLine();
            Double thirdnumber = Double.Parse(input3);


            //calculations, firstly tell the console to add the three numbers
            //next step tell the consule to multiply that number by 3//
            Double total = (firstnumber + secondnumber + thirdnumber);
            Double average = total / 3;

            //console works out maths equation and then displays the answer,
            //the {0} tells the console to enter the number there//


            Console.WriteLine("The average amount is {0}", average);

            Console.ReadKey();

        }
    }
}
