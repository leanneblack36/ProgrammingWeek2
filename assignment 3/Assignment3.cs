using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a number of seconds. Show this value as hours, minutes 
            // and seconds (hh:mm:ss, as shown on a digital alarm clock). .

            Console.WriteLine("Enter number of seconds: ");
            string input = Console.ReadLine();
            int enteredseconds = int.Parse(input);

            //work out how many hours in entered seconds = ES / 3600

            int hours = (enteredseconds / 3600);

            //work out how many seconds are in the hours
            int numberOfSecondsLeft = (hours * 3600);

            //now subrtact the seconds in the hours away from the entered seconds to see the remaining seconds
            int remainingSeconds = enteredseconds - numberOfSecondsLeft;

            //work out how many minutes are in those remaining seconds
            int minutes = remainingSeconds / 60;

            //now find out how many seconds are left
            int endseconds = enteredseconds -((hours * 3600) + (minutes * 60)); 

            //display the time in digital format hh:mm:ss

            Console.WriteLine("{0}:{1}:{2}", hours, minutes, endseconds);

             Console.ReadKey();
        }
    }
}
