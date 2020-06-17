using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        private string firstName;
        private string lastName;
        private string subject;
        private double yearsTeaching;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public double YearsTeaching
        {
            get { return yearsTeaching; }
            set { yearsTeaching = value; }
        }
}
