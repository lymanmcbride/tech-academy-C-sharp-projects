using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
{
    public class CommonMath //class name
    {
        //here are the three methods
        //note: static makes it available for use without instantiating an object.
        //public means you do need to instantiate an object to use it.
        public int Squared(int num)
        {
            int result = num * num;
            return result;
        }

        public int Doubled(int num)
        {
            int result = num + num;
            return result;
        }

        public double Half(int num)
        {
            double result = num * .5; //Whenver dividing, I always make it a floating point number for accuracy
            return result;
        }
    }
}
