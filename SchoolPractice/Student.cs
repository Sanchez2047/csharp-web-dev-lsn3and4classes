using System;
namespace SchoolPractice
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += (grade * courseCredits);
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            string gradeLevel = "";
            if (0 <= NumberOfCredits && NumberOfCredits <= 29)
            {
                gradeLevel = "Freshman";
            }
            else if (30 <= NumberOfCredits && NumberOfCredits <= 59)
            {
                gradeLevel = "Sophmore";
            }
            else if (60 <= NumberOfCredits && NumberOfCredits <= 89)
            {
                gradeLevel = "Junior";
            }
            else if (90 <= NumberOfCredits)
            {
                gradeLevel = "Senior";
            }
            return gradeLevel;
        }

        public override string ToString()
        {
            return $"Student ID: {studentId}\nStudent Name: {Name}\nCredits: {NumberOfCredits}\nGPA: {Gpa}";
        }


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
                Student i = obj as Student;
                return i.studentId == studentId && i.Name == Name;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}       
