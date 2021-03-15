using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class DisplaySecondInteger
    {
        public void DisplaySecond(int num1, int num2) //void means that it doesn't return anything
        {
            num1 += 1; //Math done with num1
            Console.WriteLine(num2); //Display num2 to console
        }
    }
}
