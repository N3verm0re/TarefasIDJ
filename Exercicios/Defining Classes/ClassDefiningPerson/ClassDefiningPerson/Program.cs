using System;
using System.Reflection;

namespace ClassDefiningPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person person1 = new Person();
            person1.age = 20;
            person1.name = "Pesho";
            Person person2 = new Person();
            person2.age = 18;
            person2.name = "Gosho";
            Person person3 = new Person();
            person3.age = 43;
            person3.name = "Stamat";

            Console.WriteLine($"Person 1:{Environment.NewLine} " +
                $"Name: {person1.name}, Age: {person1.age}");
            Console.WriteLine($"Person 2:{Environment.NewLine} " +
                $"Name: {person2.name}, Age: {person2.age}");
            Console.WriteLine($"Person 3:{Environment.NewLine} " +
                $"Name: {person3.name}, Age: {person3.age}");
        }
    }
}
