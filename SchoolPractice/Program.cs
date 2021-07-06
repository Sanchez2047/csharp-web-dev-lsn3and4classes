using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.

            Student Billy = new Student("Billy", 001, 19, 4.0);
            Student Blake = new Student("Blake", 002, 43, 2.7);
            Student Jacob = new Student("Jacob", 003, 77, 3.6);
            Student Lucy = new Student("Lucy", 004, 72, 3.3);
            Student Shelby = new Student("Shelby", 005, 97, 2.9);

            Teacher Johnson = new Teacher("Judy", "Johnson", "Math", 15);
            Course Math = new Course();
            Math.Topic = "Math";
            Math.Instructor = Johnson;
            Math.Enroll(Billy);
            Math.Enroll(Blake);
            Math.Enroll(Jacob);
            Math.Enroll(Lucy);
            Math.Enroll(Shelby);

            Teacher White = new Teacher("Hank", "White", "Science", 9);
            Course Science = new Course();
            Science.Topic = "Science";
            Science.Instructor = White;
            Science.Enroll(Billy);
            Science.Enroll(Blake);
            Science.Enroll(Jacob);
            Science.Enroll(Lucy);
            Science.Enroll(Shelby);

            Console.WriteLine(Science.ToString());
            Console.WriteLine();
            Console.WriteLine(Science.Equals(Math));
            Console.WriteLine();
            Console.WriteLine(Billy.ToString());
            Console.WriteLine();
            Console.WriteLine(Blake.ToString());
            Console.WriteLine();
            Console.WriteLine(Billy.Equals(Blake));
            Console.WriteLine();
            Console.WriteLine(Billy.Equals(Billy));


            Console.ReadLine();


        }
    }
}
