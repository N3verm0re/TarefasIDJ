using System;
using System.Text;

namespace InheritanceMankind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Student Full Name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Input Student Faculty Number:");
            int studentFacultyNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Worker First Name:");
            string workerName = Console.ReadLine();
            Console.WriteLine("Input Worker Last Name:");
            workerName = $"{workerName} {Console.ReadLine()}";
            Console.WriteLine("Input Worker Work Hours Per Day:");
            double workerHoursPerDay = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input Worker Weekly Salary:");
            double workerWeekSalary = Double.Parse(Console.ReadLine());

            Student student = new Student(studentName, studentFacultyNumber);
            Worker worker = new Worker(workerName, workerHoursPerDay, workerWeekSalary);

            Console.WriteLine("/////Student/////");
            Console.WriteLine(student);
            Console.WriteLine("/////Worker/////");
            Console.WriteLine(worker);
        }
    }
}
