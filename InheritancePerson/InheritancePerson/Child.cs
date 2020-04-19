using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePerson
{
    public class Child : Person
    {
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if(value < 0 || value > 15) { throw new ArgumentException("Age must be positive and less than 15 for a Child"); }
                base.Age = value;
            }
        }

        public Child(string name, int age) : base(name, age) { }
    }
}
