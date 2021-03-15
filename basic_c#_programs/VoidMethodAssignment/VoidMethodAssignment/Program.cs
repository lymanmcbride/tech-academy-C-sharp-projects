using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            DisplaySecondInteger displayInt = new DisplaySecondInteger();

            //call the method twice
            displayInt.DisplaySecond(2, 4); //parameters passed in with nums only
            displayInt.DisplaySecond(num1: 3, num2: 5); //parameters passed in with names assigned for readibility

            //make sure we can see it
            Console.ReadLine();
        }
    }
}
