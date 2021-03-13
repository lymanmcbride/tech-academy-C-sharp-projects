using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of strings
            string[] string_array = { "run", "jump", "hike", "spit", "laugh", "bike", "sleep", "eat" };
            //get input from user
            Console.WriteLine("Please input a suffix for a verb. (er, ing, ed, etc.)");
            string suffix = Console.ReadLine();

            //append the user's input to the end of each string
            for (int i = 0; i < string_array.Length; i++)
            {
                string_array[i] = string_array[i] + suffix;
            }

            //Print the new strings from the array to the console
            foreach (string verb in string_array)
            {
                Console.WriteLine(verb);
            }
            Console.ReadLine();


            //First created an infinite loop without l++, then I added it to be able to break the loop.
            int l = 0;
            while (l <= 5)
            {
                Console.WriteLine("No longer an infinite loop!");
                l++;                
            }
            Console.ReadLine();

            //create an array of integers 
            int[] int_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //This is a random loop that uses a < sign.
            for (int i = 0; i < int_array.Length; i++)
            {
                if (int_array[i] == 10)
                {
                    Console.WriteLine("We have a 10!");
                }
                else if (i == int_array.Length - 1)
                {
                    Console.Write("We do not have a 10");
                }
            }

            //setting up a while loop and getting input from the user on how many times it should run
            int k = 1;
            Console.WriteLine("\nPlease enter the amount of times you want this loop to run");
            int times = Convert.ToInt32(Console.ReadLine());
            //This was to use a <= sign. It makes the loop run as many times as the user inputs. 
            while (k <= times)
            {
                Console.WriteLine("Iteration: " + k);
                k++;
            }
            Console.ReadLine();

            //A list of strings
            List<string> string_list = new List<string>() { "Kurt", "Carrie", "Ben", "Joe", "Coby", "Kurt" };
            Console.WriteLine("Please input the name you would like to search for in the string list");
            string desired_name = Console.ReadLine();

            //This loop searches for the input from the user and breaks on the first instance it finds. 
            for (int i = 0; i < string_list.Count; i++)
            {
                if (string_list[i] == desired_name)
                {
                    Console.WriteLine("The index of " + desired_name + " is: " + i);
                    break; //here is our break statement
                }
                else if (i == string_list.Count - 1) //if we get to the end and we haven't run the if statement yet, then we know we didn't find the name
                {
                    Console.WriteLine("The name you entered is not on the list");
                }
            }

            //instantiate another list of strings with a few identical strings.
            List<string> two_identical = new List<string>() { "Mom", "Dad", "Daughter", "Son", "Mom", "Dad" };
            Console.WriteLine("Please input a title for family member (Mom, Dad, etc.)");
            string desired_title = Console.ReadLine();


            bool exists = false; //necessary to make sure we don't run the "else if" statement on the last element.
            for (int i = 0; i < two_identical.Count; i++)
            {
                if (two_identical[i] == desired_title)
                {
                    Console.WriteLine("The index of " + desired_title + " is: " + i);
                    exists = true; //change the boolean so that we know we have found at least one match
                }
                else if (i == two_identical.Count - 1 && !exists) //without !exists this code would run every time, unless the user inputs the element that happens to be last on the list
                {
                    Console.WriteLine("That title is not in the list");
                }
            }
            Console.ReadLine();

            List<string> already_in_list = new List<string>();//we need a place to store elements we run accross, so I instantiated a list here for that
            foreach (string title in two_identical)
            {
                if (already_in_list.Contains(title)) //There's probably a better way to write this, but if we have stored the element in the list
                                                    //of elements we have run accross, then we run this code, otherwise we run the other code and add it to the list.
                {
                    Console.WriteLine(
                        "\n\nThe title at this index is: " + title + 
                        " \nAppeared in the list? Yes!"
                        );
                }
                else
                {
                    Console.WriteLine(
                        "\n\nThe title at this index is: " + title +
                        " \nAppeared in the list? No"
                        );
                    already_in_list.Add(title);
                }
            }
            Console.ReadLine();
        }
    }
}
