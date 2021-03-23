using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmit
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();//this is the abstract class.

        public virtual void Introduction() //this is the virtual class. All we have on the person level
                                           //is the name, so I
                                           //implemented that, but I'll add the rest on the employee class.
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
