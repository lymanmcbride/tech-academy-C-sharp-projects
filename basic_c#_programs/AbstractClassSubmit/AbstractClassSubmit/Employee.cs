using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmit
{
    public class Employee : Person, IQuittable
    {
        public override void SayName() //this is the implementation of the abstract SayName Method
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public override void Introduction() //This changes slightly the implementation of the Introduction method
        {
            
            base.Introduction();
            Console.WriteLine("Employee");
        }

       public void Quit() //implementation of Quit for Employees
        {
            Console.WriteLine("Do you want to quit? y/n");
            string response = Console.ReadLine().ToLower();

            if (response == "y")
            {
                System.Environment.Exit(0);
            }
        }
    }
}
