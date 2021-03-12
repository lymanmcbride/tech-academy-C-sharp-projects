using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number";
            Console.WriteLine(result);
            Console.ReadLine();

            //int roomTemp = 70;

            //Console.WriteLine("Hi, What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //Console.ReadLine();

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp" : "It is not room temp";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It's exactly room temperature");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("Current temp is warmer than room temp");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("room temp is warmer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("It's not exactly room temperature");
            //}
            //Console.ReadLine();
        }
    }
}
