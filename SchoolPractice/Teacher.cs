using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private int _yearsTeaching;

        public int YearsTeaching
        {
            get { return _yearsTeaching; }
            set { _yearsTeaching = value; }
        }





    }
}
