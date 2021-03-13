using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try Catch block to check for incorrect user inputs
            try
            {
                //make the list
                List<int> integers = new List<int> { 5, 3, 7, 16, 25, 100, -2, -30, -100, 5, 7, 100, -30 };

                //get input
                Console.WriteLine("Enter an integer to divide the values in the list by.");
                double input = Convert.ToDouble(Console.ReadLine()); //I used double in case they wan't to enter a decimal

                //The below is necessary because floating point numbers don't throw a divide by 0 exception. 
                //Instead they print infinity or -infinity. So I had to handle that case myself.
                if (input == 0)
                {
                    Console.WriteLine("You can't divide by 0.");
                }

                else
                {
                    //Print out the result of the math
                    foreach (double num in integers)
                    {
                        double display = num / input;
                        Console.WriteLine(display);
                    }
                }

            }
            //Printing out the result of the exception if one occurs. 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //We made it through the try/catch block!
            Console.WriteLine("You made it through the try/catch block!");
            Console.ReadLine();

        }
    }
}
