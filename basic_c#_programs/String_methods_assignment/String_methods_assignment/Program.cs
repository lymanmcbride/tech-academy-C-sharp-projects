using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_methods_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Three Strings
            string string1 = "Hello, ";
            string string2 = "my name is ";
            string string3 = "Lyman";

            //Concatenate them together, while using a string method to make HELLO more like a nervous shout or something.
            string sentence = string1.ToUpper() + string2 + string3;

            //Uing StringBuilder to append sentences to each other and make a paragraph. 
            StringBuilder sb = new StringBuilder(); //It's an object, declared here.
            sb.Append(sentence); //the append method is applied to the stringBuilder object, it's not a regular string method. 
            sb.Append(" I am a Software Engineer. ");
            sb.Append("Let me tell you a little bit about myself. ");
            sb.Append("I trained in C# and Python at The Tech Academy. ");
            sb.Append("I love building complex systems and working on a team. ");
            sb.Append("I trained as a professional musician at two of the world's top conservatories, " +
                "The Curtis Institue of Music and the Yale School of Music. ");
            sb.Append("In school I learned how to work REALLY hard. ");
            sb.Append("I also learned how to prioritize my time and effectiveness. ");
            sb.Append("This work ethic isn't what I do, it's who I am. ");

            //Print it out
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
