using System;

namespace InheritancePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Insert Age:");
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
