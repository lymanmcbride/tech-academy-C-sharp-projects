using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>(); //Declare the list
            //Add 10 new employees. This way you don't hve to assign them to a variable name. 
            Employees.Add(new Employee() { FirstName = "Lyman", LastName = "McBride", ID = 1 });                
            Employees.Add(new Employee() { FirstName = "Joe", LastName = "Shmo", ID = 2 });
            Employees.Add(new Employee() { FirstName = "Jeff", LastName = "Bridges", ID = 3 });
            Employees.Add(new Employee() { FirstName = "Joe", LastName = "Biden", ID = 4 });
            Employees.Add(new Employee() { FirstName = "Keil", LastName = "McBride", ID = 5 });
            Employees.Add(new Employee() { FirstName = "Lane", LastName = "Man", ID = 100 });
            Employees.Add(new Employee() { FirstName = "Lance", LastName = "Lancet", ID = 90 });
            Employees.Add(new Employee() { FirstName = "Logan", LastName = "Anderson", ID = 12 });
            Employees.Add(new Employee() { FirstName = "Wolverine", LastName = "TheMan", ID = 6 });
            Employees.Add(new Employee() { FirstName = "Dude", LastName = "McBride", ID = 7 });
        

            List<Employee> FirstJoe = new List<Employee>(); //For using the foreach loop
            
            foreach (Employee person in Employees)
            {
                if (person.FirstName == "Joe") //Filtering for first name "joe"
                {
                    FirstJoe.Add(person);
                }
            }

            //below does the same thing as the foreach loop but in a lambda function. don't forget ToList
            List<Employee> FirstJoeLambda = Employees.Where(person => person.FirstName == "Joe").ToList();

            //person is the parameter. This pulls out people whose IDs are greater than 5
            List<Employee> GreaterThanFive = Employees.Where(person => person.ID > 5).ToList();

            //print out each of them to the console.
            Console.WriteLine("Here is the list from the foreach loop:");
            foreach (Employee item in FirstJoe)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            Console.WriteLine("\nHere is the list from the Lambda function:");
            foreach (Employee item in FirstJoeLambda)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            Console.WriteLine("\nHere is the list from the lambda function where IDs are greater than 5:");
            foreach (Employee item in GreaterThanFive)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.ReadLine();


        }
    }
}
