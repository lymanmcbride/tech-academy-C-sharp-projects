using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultMath powerOf = new DefaultMath();
            Console.WriteLine("Please enter at least one integer. " +
                "\nIf you do two, the first number will be taken to the power of the second number." +
                "\nTo do so, enter the first number, then press return, then enter the second number." +
                "\nIf you do only one, the first number will be taken to the power of 1. Enter the first number then press enter twice.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result;
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                result = powerOf.Power(num1, num2);
            }
            catch (Exception)
            {
                result = powerOf.Power(num1);
            }

            Console.WriteLine(
                "The result of your math is: " + result
                );
            Console.ReadLine();
        }
    }
}
