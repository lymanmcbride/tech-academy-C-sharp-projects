using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get an initial value
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            //declare the while loop for their response, until they pick blue
            while (color != "blue")
            {
                Console.WriteLine("There's a better color out there. Try again!");
                color = Console.ReadLine();
            }
            //You know they have picked blue once the while loop has broken
            Console.WriteLine("You've got it!");


            bool go = false; //declare our value for breaking the while loop
            //do all of this stuff until the while loop breaks. 
            do
            {
                Console.WriteLine("\nWhat is the best snack?"); 
                string snack = Console.ReadLine(); //get a response
                switch (snack) //give some prepared responses
                {
                    case "crackers":
                        Console.WriteLine("Crackers are pretty good. But not quite the best");
                        break;
                    case "girl scout cookies":
                        Console.WriteLine("Hard to argue, but I'd put forth a better option!");
                        break;
                    case "apples and peanut butter":
                        Console.WriteLine("That's more like it! You've got it.");
                        Console.ReadLine();
                        go = true; //break the while loop so that it doesn't keep running after they type the desired answer.
                        break;
                    default:
                        Console.WriteLine("You've sure got imagination");
                        break;
                }
            }
            while (!go);



        }
    }
}
