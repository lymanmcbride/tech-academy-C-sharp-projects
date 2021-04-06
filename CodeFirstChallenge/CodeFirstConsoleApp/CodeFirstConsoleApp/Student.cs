using System.Collections.Generic;


namespace CodeFirstConsoleApp
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal GPA { get; set; }

        public virtual List<Activity> Activity { get; set; }
    }

    public class Activity
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
    }
}
