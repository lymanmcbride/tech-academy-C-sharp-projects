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

            //use the methods.
            CommonMath doMath = new CommonMath();
            int square = doMath.Squared(input);
            int doubled = doMath.Doubled(input);
            double half = doMath.Half(input);

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
