using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class DivideTwo
    {
        //Method that divides by two and returns the number
        public int Divide(int num)
        {
            int return_num = num / 2;
            return return_num;
        }

        //Method that does the same as above but is void
        public void DivideVoid(int num)
        {
            int returnNum = num / 2;
            Console.WriteLine(returnNum);
        }

        //method that uses an out parameter
        public string SaySomething(string sentence, out int count)
        {
            count = 0;
            for (int i = 0; i < 6; i++)
            {
                count++;
            }
            return sentence;
        }

        //overloaded method with a count parameter
        public string SaySomething(string sentence, out int count, int times)
        {
            count = 0;
            for (int i = 0; i < times; i++)
            {
                count++;
            }
            return sentence;
        }
    }
}
