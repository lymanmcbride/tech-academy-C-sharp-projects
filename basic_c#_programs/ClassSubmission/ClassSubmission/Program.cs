using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare divideTwo object 
            DivideTwo Division = new DivideTwo();

            //First method that is not void, and returns an integer.
            //Get input from user
            Console.WriteLine("Enter an integer to divide by two");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2 == 0) //we are returning an int, so the result of the division has to be int.
            {
                int return_num = Division.Divide(num);
                Console.WriteLine(return_num);
            }
            else
            {
                Console.WriteLine("Input must be an even number");
            }

            //Second method that is void and prints the result of num/2
            Console.WriteLine("here is the result of the void method:");
            if (num % 2 == 0) //we are returning an int, so the result of the division has to be int.
            {
                Division.DivideVoid(num);
            }
            else
            {
                Console.WriteLine("Input must be an even number");
            }

            //Method with out variable below
            //count will be our out variable. 
            int count;
            Console.WriteLine("Enter a sentence"); //get input from user
            string sentence = Console.ReadLine();
            Console.WriteLine(Division.SaySomething(sentence, out count)); //write the result of the function
            Console.WriteLine(count); //write Count so we can see the change

            //the overloaded method is below
            count = 0; //reassign count
            Console.WriteLine("Enter an amount of times to do the loop"); //get input for the new variable.
            int times = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Division.SaySomething(sentence, out count, times));
            Console.WriteLine(count);

            //using a static class below. 
            Console.WriteLine("Enter an integer to divide by 3");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DivideThree.DivideByThree(num)); //static means you have to use the class name rather than instantiate an object.
            Console.ReadLine();


        }
    }
}
