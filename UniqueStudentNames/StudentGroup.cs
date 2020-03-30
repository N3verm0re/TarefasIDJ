using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueStudentNames
{
    class StudentGroup
    {
        static HashSet<String> StudentNames = new HashSet<String>();
        public static int counter;

        public static void AddStudent(string Name)
        {
            StudentNames.Add(Name);
            counter = StudentNames.Count;
        }
    }
}
