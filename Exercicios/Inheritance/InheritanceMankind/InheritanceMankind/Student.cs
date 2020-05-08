using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceMankind
{
    class Student : Human
    {
        private int facultyNumber;
        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if(!(value.ToString().Length <= 10 && value.ToString().Length >= 5)) { throw new ArgumentException("Invalid faculty number!"); }
                this.facultyNumber = value;
            }
        }

        public Student(string fullName, int facultyNumber) : base(fullName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            string classToString = $"First Name: {this.FirstName}{Environment.NewLine}" +
                $"Last Name: {this.LastName}{Environment.NewLine}" +
                $"Faculty Number: {this.FacultyNumber}";
            return classToString;
        }
    }
}
