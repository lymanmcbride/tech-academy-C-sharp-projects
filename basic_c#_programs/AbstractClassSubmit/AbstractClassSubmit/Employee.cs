using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmit
{
    public class Employee : Person
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
    }
}
