using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class MathOverload
    {
        //first method takes int, returns int to power of 3
        public int PowerThree(int num)
        {
            return num * num * num;
        }

        //second method takes double, returns double, to power of 3, divided by 2
        public double PowerThree(double num)
        {
            return (num * num * num) / 2;
        }

        //Third method takes string, converts to int, takes it to the power of 3 and adds two.
        //No division so that decimals won't appear
        public int PowerThree(string numString)
        {
            int num = Convert.ToInt32(numString);
            return (num * num * num)+2;
        }
    }
}
