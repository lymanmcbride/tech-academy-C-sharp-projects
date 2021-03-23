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
            Test.Introduction();
            Console.ReadLine();
        }
    }
}
