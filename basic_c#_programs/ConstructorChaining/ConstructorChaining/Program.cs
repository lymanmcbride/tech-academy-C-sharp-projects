using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstName = "Lyman"; //Created a constant
            var lastName = "McBride"; //created a strin using "var"
            Person Friend = new Person("Keil"); //instantiated an object of person class uing a chained construcgtor
            Console.ReadLine(); //for setting the breakpoint
        }

        
    }
    public class Person
    {
        public Person(string name) : this(name, "Student") { } //chained constructor, inherits from below, default title is "student"
        public Person(string name, string title)//main constructor
        {
            Name = name;
            Title = title;
        }

        //properties set here are assigned by the constructor
        public string Name { get; private set; }
        public string Title { get; set; }
    }
}
