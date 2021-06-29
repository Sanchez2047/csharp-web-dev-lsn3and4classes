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
        public List<double> TotalCredits { get; set; }
        public static Dictionary<Student, int> courses { get; set; } = new Dictionary<Student, int>(); 


 

    }
}
