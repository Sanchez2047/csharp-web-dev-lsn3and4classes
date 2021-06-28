using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student student1 = new Student();
            student1.Name = "Mike";
            student1.NumberOfCredits = 1;
            student1.Gpa = 4.0;

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.NumberOfCredits);
            Console.WriteLine(student1.Gpa);

            Console.ReadLine();
        }
    }
}
