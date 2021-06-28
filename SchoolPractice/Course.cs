using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SchoolPractice
{
    class Course
    {
        public Student student2 = new Student();

        public string CourseName { get; set; }
        public double CreditsNum { get; set; }
        public string StudentCourse { get; set; }
        public List<double> TotalCredits { get; set; }

        private Dictionary<string, double> courses = new Dictionary<string, double>(); 

        public double Credits
        {
            get
            {
                courses.Add(CourseName, CreditsNum);
                foreach(var course in courses)
                {
                    if (course.Key == StudentCourse)
                    {
                        TotalCredits.Add(course.Value);
                    }
                }
                return TotalCredits.Sum();

            }  

        }

 

    }
}
