using System;
using System.Linq;
using System.Data.Entity;

namespace CodeFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                //create and save new Student
                Console.Write("Student's First Name: ");
                var firstName = Console.ReadLine();
                Console.Write("Student's Last Name: ");
                var lastName = Console.ReadLine();
                Console.Write("Student's GPA: ");
                decimal gpa = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Add an activity: ");
                var activityName = Console.ReadLine();

                var student = new Student { FirstName = firstName, LastName = lastName, GPA = gpa };
                var activity = new Activity { ActivityName = activityName };
                db.Students.Add(student);
                db.Activity.Add(activity);
                db.SaveChanges();

                //query for viewing. needs system.LINQ
                var query = from b in db.Students orderby b.LastName select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
        }
    }
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Activity> Activity { get; set; }
    }
}
