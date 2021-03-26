using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //used for reading and writing

namespace LoggingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer");
            string Num =Console.ReadLine();
            File.WriteAllText(@"C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\logs\practice_log.txt", Num);
            string toPrint = File.ReadAllText(@"C:\Users\Lyman\Desktop\coding\portfolio_pieces\tech_academy_projects\tech-academy-C-sharp-projects\logs\practice_log.txt");
            Console.WriteLine("Here's what we wrote to the file: {0}", toPrint);
            Console.ReadLine();
        }
    }
}
