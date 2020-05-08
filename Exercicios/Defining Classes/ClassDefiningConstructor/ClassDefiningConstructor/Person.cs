using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDefiningConstructor
{
    class Person
    {
        public int age;
        public string name;

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age)
        {
            this.age = age;
            name = "No name";
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
