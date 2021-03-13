using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from the user
            Console.WriteLine("What integer do you want to do math with?");
            int input = Convert.ToInt32(Console.ReadLine());

            //use the methods. I guess these methods cannot be accessed by an 
            //instance of the class, you just reference the class to access them
            int square = common_math.Squared(input);
            int doubled = common_math.doubled(input);
            double half = common_math.half(input);

            //print it out
            Console.WriteLine(
                "Squared: " + square + 
                "\nDoubled: "+ doubled + 
                "\nHalved: " + half
                );
            Console.ReadLine();
        }
    }
}
