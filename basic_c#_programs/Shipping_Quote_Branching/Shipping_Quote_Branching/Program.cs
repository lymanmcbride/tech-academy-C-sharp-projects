using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote_Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro text
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            //Get weight
            Console.WriteLine("What is the weight of the package?");
            double weight = Convert.ToDouble(Console.ReadLine());

            //Check weight against requirements
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
            }
            else
            {
                //Get dimensions
                Console.WriteLine("What is the package width?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                double length = Convert.ToDouble(Console.ReadLine());
                
                //Check size against requirements
                if (width+height+length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via package Express.");
                    Console.ReadLine();
                }
                else
                {
                    //Calculate quote and return to user
                    double quote = (height * width * length * weight) / 100; //how quote is calculated
                    string quote_string = String.Format("{0:0.00}", quote); //format the quote to have two decimal places
                    Console.WriteLine(
                        "Your estimated total for shipping this package is:" +
                        "\n$" + quote_string
                        );
                    Console.ReadLine();
                }

            }


        }
    }
}
