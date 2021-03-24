using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsParsing
{
    class Program
    {
        static void Main()
        {
            //get input
            Console.WriteLine("Please enter the current day of the week");
            string TodayString = Console.ReadLine();

            //USING PARSE()
            try
            {
                DaysOfWeek Today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), TodayString); //parses the enum and turns input into an enum variable
                Console.WriteLine(Today);
                Console.WriteLine((int)Today);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Main();//recursive call to give the user another chance
            }

            //USING TRYPARSE
            //cast to daysofweek
            //DaysOfWeek Today;//define variable that will eventually hold it
            //if (Enum.TryParse(TodayString, out Today) is false) //tryparse eliminates the need for exception handling. It returns false if it's not found
            //{
            //    Console.WriteLine("Please enter a real day in english");
            //    Main();
            //}
            //else
            //{
            //    Enum.TryParse(TodayString, out Today);
            //    Console.WriteLine(Today);
            //    Console.WriteLine((int)Today);
            //    Console.ReadLine();
            //}

        }
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
