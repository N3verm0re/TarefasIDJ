using System;

namespace UniqueStudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            while(command != "End") 
            {
                Student student = new Student(command);
                command = Console.ReadLine();
            }

            Console.WriteLine("There are {0} unique student names.", StudentGroup.counter);
        }
    }
}