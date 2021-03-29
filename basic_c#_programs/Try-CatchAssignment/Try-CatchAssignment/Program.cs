using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_CatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try catch block for the program
            {
                useProgram();
            }
            catch (LessThanOneException) //I made this exception below
            {
                Console.WriteLine("This program is for children and adults 1 and up!");
                Console.ReadLine();
                return;
            }
            catch (Exception) //catch all
            {
                Console.WriteLine("Something went wrong. Please contact Lyman. He wrote the darn thing.");
                Console.ReadLine();
                return;
            }
        }

        static void useProgram() //method that contains the main program
        {
            bool validAge = false;
            int age = 0; //instantiated for the out parameter in tryparse
            while (!validAge)
            {
                Console.WriteLine("Please enter your age in years");
                validAge = int.TryParse(Console.ReadLine(), out age); //tryparse returns a bool and the out parameter of age converted to int
                if (!validAge) Console.WriteLine("Please enter an integer only");
            }
            if (age < 1) //throwing exception for babies and negative numbers
            {
                throw new LessThanOneException();
            }
            int yearBorn = DateTime.Now.Year - age;
            Console.WriteLine("You were born sometime between {0} and {1}.", yearBorn - 1, yearBorn); //you can't tell someone's year of birth by their age
            Console.ReadLine();
            
        }

    }

    public class LessThanOneException : Exception //this inherits from Exception
    {
        public LessThanOneException() //overloaded constructors.
            : base() { }
        public LessThanOneException(string message)
            : base(message) { }
    }
}
