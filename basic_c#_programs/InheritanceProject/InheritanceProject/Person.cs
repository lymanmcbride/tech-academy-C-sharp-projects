using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //method for saying the name
        public void SayName()
        {
            string Output = $"Name: {FirstName} {LastName}"; //a nice way to format our say name method
            Console.WriteLine(Output);//write it to the console
        }
    }
}
