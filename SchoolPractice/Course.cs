using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents = new List<Student>();


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.
        public void Enroll(Student name)
        {
            enrolledStudents.Add(name);
        }
        public override string ToString()
        {
            return $"{Topic}\nInstructor: {Instructor.LastName}, {Instructor.FirstName}\nNumber of Students Enrolled: {enrolledStudents.Count}"; 
        }


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Course i = obj as Course;
                return i.Topic == Topic && i.Instructor == Instructor;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
