using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
{
    class common_math //class name
    {
        //here are the three methods
        public static int Squared(int num)
        {
            int result = num * num;
            return result;
        }

        public static int doubled(int num)
        {
            int result = num + num;
            return result;
        }

        public static double half(int num)
        {
            double result = num * .5; //Whenver dividing, I always make it a floating point number for accuracy
            return result;
        }
    }
}
