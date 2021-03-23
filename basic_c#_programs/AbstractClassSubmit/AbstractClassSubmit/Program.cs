using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmit
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Test = new Employee() { FirstName = "Lyman", LastName = "McBride" };//instantiate a new employee
            
            //use the two methods
            Test.SayName();
            Console.ReadLine();

            //create object of iquittable type. Instantiated polymorphed from Employee so it has Employee's functionality
            IQuittable IQuit = new Employee() { FirstName = "Jeff", LastName = "Bridges" };
            IQuit.Quit(); //calling quit method
            
            Test.Introduction();
            Console.ReadLine();
        }
    }
}
