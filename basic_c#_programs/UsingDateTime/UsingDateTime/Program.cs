using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //write the current datetime to the console
            Console.WriteLine("The Current date and time is: {0}", DateTime.Now);

            //get the hours to add to the current datetime
            Console.WriteLine("Please enter the number of hours we will add to the current datetime.");
            double hours = Convert.ToDouble(Console.ReadLine());

            //add hours to the current time using the handy dandy AddHours method.
            DateTime projectedTime = DateTime.Now.AddHours(hours);

            //write to console
            Console.WriteLine($"In {hours} hours the datetime will be {projectedTime}");
            Console.ReadLine();
        }
    }
}
