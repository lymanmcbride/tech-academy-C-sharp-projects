using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            MathOverload doingMath = new MathOverload();

            //Three method uses
            int powerOfThree = doingMath.PowerThree(3);
            double decimalMath = doingMath.PowerThree(3.46);
            int stringConvert = doingMath.PowerThree("5");

            //print them out
            Console.WriteLine("Three To the Power of Three: " + powerOfThree);
            Console.WriteLine("3.46 to the power of 3 divided by two: " + decimalMath);
            Console.WriteLine("\"5\" converted to a string and given the power of 3 plus two:" + stringConvert);
            Console.ReadLine();
        }
    }
}
