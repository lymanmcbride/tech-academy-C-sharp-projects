using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get info
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?(True/False)");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());

            //A simple way to display true or false depending on whether each of the conditions are true
            bool qualified = (age > 15) && (!dui) && (tickets <= 3);

            //Display Result
            Console.WriteLine("Let's see if you are qualified...\n" + qualified);
            Console.ReadLine();


        }
    }
}
