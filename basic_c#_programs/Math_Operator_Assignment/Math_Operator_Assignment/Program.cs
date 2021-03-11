using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input
            Console.WriteLine("Please type in any number");
            string string_num = Console.ReadLine();
            decimal num = Convert.ToDecimal(string_num); //convert to decimal so maths can be used. In case the input is a decimal, I've explicitly converted it to decimal

            // Maths operations
            decimal step_1 = num * 50;
            decimal step_2 = num + 25;
            decimal step_3 = num / (decimal)12.5;
            bool step_4 = num > 50;
            decimal step_5 = num % 7;

            //print result

            Console.WriteLine(
                "Here are your operations: " +
                "\nStep 1: multiply by 50: " + step_1 +
                "\nStep 2: add 25: " + step_2 +
                "\nStep 3: divide by 12.5: " + step_3 +
                "\nStep 4: Is it greater than 50? " + step_4 +
                "\nStep 5: Divide by 7 and get remainder: " + step_5
                );

            Console.ReadLine();
        }
    }
}
