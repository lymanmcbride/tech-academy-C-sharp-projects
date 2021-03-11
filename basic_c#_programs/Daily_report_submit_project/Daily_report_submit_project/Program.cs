using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_report_submit_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro Text
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            //Questions
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string page_string = Console.ReadLine();
            Int32 page_number = Convert.ToInt32(page_string); //Converts to int

            Console.WriteLine("Do you need help with anything? (True/False)");
            string help_string = Console.ReadLine();
            bool help = Convert.ToBoolean(help_string); //converts to boolean

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positive_experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many Hours did you study today?");
            string hours_string = Console.ReadLine();
            Int16 hours = Convert.ToInt16(hours_string); //converts to int

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. \nHave a great day!");
            Console.ReadLine();

        }
    }
}
