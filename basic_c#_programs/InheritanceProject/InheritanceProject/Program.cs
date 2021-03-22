using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize test employee
            Employee Test = new Employee() { FirstName = "Sample", LastName = "Student" };
            Test.SayName(); //Test the inherited method
            Console.ReadLine(); //so we can see it
        }
    }
}
