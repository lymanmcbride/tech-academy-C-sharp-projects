using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number() { Amount = 104.235M };//assigning a decimal amount to a variable. remember that
                                                            //you have to add M to the end for it to be a decimal.
            Console.WriteLine($"The number assigned to our struct Number is: {num.Amount}"); //print it out
            Console.ReadLine();
        }
    }
}
