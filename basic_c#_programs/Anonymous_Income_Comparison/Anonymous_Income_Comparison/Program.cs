using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening Stement-------------------------------------------
            Console.WriteLine("Anonymous Income Comparison Program");


            //Get info--------------------------------------------------

            //person1
            Console.WriteLine(
                "Person 1: " +
                "\nWhat is your hourly rate?"
                );
            string person1_rate_string = Console.ReadLine();
            double person1_hourly_rate = Convert.ToDouble(person1_rate_string); //Convert to double in case they make a certain amount of cents per hour

            Console.WriteLine(
                "And what is your hours worked per week?"
                );
            string person1_hours = Console.ReadLine();
            double person1_hours_worked = Convert.ToDouble(person1_hours); //This converts to double to make the math easier later

            //person2
            Console.WriteLine(
                "Person 2: " +
                "\nWhat is your hourly rate?"
                );
            string person2_rate_string = Console.ReadLine();
            double person2_hourly_rate = Convert.ToDouble(person2_rate_string);

            Console.WriteLine(
                "And what is your hours worked per week?"
                );
            string person2_hours = Console.ReadLine();
            double person2_hours_worked = Convert.ToDouble(person2_hours);


            //Do needed math for display ----------------------------------------------------

            double person1_salary = person1_hourly_rate * person1_hours_worked * 52;
            double person2_salary = person2_hourly_rate * person2_hours_worked * 52;
            bool person1MoreThanPerson2 = person1_salary > person2_salary;


            //Write results to Console-----------------------------------------------------------
            Console.WriteLine(
                "Annual Salary of Person 1: " + person1_salary +
                "\nAnnual Salary of Person 2: " + person2_salary + 
                "\nDoes person 1 make more money than person 2? " + person1MoreThanPerson2
                );
            Console.ReadLine();

        }
    }
}
