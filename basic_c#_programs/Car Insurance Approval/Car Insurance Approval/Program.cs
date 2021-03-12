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
            string age_string = Console.ReadLine();
            Int16 age = Convert.ToInt16(age_string); //convert each bit of info to the corect data type

            Console.WriteLine("Have you ever had a DUI?(True/False)");
            string dui_string = Console.ReadLine();
            bool dui = Convert.ToBoolean(dui_string);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets_string = Console.ReadLine();
            Int16 tickets = Convert.ToInt16(tickets_string);

            //A simple way to display true or false depending on whether each of the conditions are true
            bool qualified = (age > 15) && (!dui) && (tickets <= 3);

            //Display Result
            Console.WriteLine("Let's see if you are qualified...\n" + qualified);
            Console.ReadLine();


        }
    }
}
