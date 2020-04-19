using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePerson
{
    public class Person
    {
        private string name;
        private int age;

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value.Length < 3) { throw new ArgumentException("Name's Length should not be shorter than 3 symbols!"); }
                this.name = value;
            }
        }
        public virtual int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value >= 0) { this.age = value; }
                else { throw new ArgumentException("Age must be Positive!"); }
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            string classString = $"Name: {this.Name}, Age: {this.Age}";
            return classString;
        }
    }
}
