using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueStudentNames
{
    class Student
    {
        public string name;

        public Student(string Name)
        {
            name = Name;
            StudentGroup.AddStudent(name);
        }
    }
}
