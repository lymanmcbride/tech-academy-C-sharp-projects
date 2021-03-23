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
            Employee first = new Employee() { FirstName = "Lyman", LastName = "McBride", ID = 14567};//instantiate a new employee
            Employee second = new Employee() { FirstName = "Lyman", LastName = "McBride", ID = 14569 };//instantiate a second employee
            //use the two methods
            first.SayName();
            Console.ReadLine();
            first.Introduction();
            Console.ReadLine();

            //create object of iquittable type. Instantiated polymorphed from Employee so it has Employee's functionality
            IQuittable IQuit = new Employee() { FirstName = "Jeff", LastName = "Bridges", ID = 14568};
            IQuit.Quit(); //calling quit method           

            //check overloaded == operator and !=
            Console.WriteLine(first == second);
            Console.WriteLine(first != second);
            Console.ReadLine();

        }
    }
}
