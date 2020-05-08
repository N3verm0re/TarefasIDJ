using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceMankind
{
    class Human
    {
        private string fullName;
        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                string[] names = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if(!Char.IsUpper(names[0][0])) { throw new ArgumentException("Expected upper case letter! Argument: firstName"); }
                if(names[0].Length < 4) { throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName"); }
                char firstletter = names[1][0];
                if(!Char.IsUpper(names[1][0])) { throw new ArgumentException("Expected upper case letter! Argument: lastName"); }
                if(names[1].Length < 3) { throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName"); }
                this.fullName = value;
            }
        }

        public string FirstName
        {
            get
            {
                string[] names = this.fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return names[0];
            }
            set
            {
                string[] names = this.fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (Char.IsUpper(value[0])) { throw new ArgumentException("Expected upper case letter! Argument: lastName"); }
                if (value.Length < 3) { throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName"); }
                names[0] = value;
                this.fullName = $"{names[0]} {names[1]}";
            }
        }

        public string LastName
        {
            get
            {
                string[] names = this.fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return names[1];
            }
            set
            {
                string[] names = this.fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (!Char.IsUpper(value[0])) { throw new ArgumentException("Expected upper case letter! Argument: firstName"); }
                if (value.Length < 4) { throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName"); }
                this.fullName = $"{names[0]} {names[1]}";
            }
        }

        public Human(string fullName)
        {
            this.FullName = fullName;
        }

        public override string ToString()
        {
            string classToString = $"First Name: {this.FirstName}{Environment.NewLine}" +
                $"Last Name: {this.LastName}{Environment.NewLine}";
            return classToString;
        }
    }
}
