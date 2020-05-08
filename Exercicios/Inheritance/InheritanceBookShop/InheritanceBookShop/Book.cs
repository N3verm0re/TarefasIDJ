using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBookShop
{
    public class Book
    {
        private string author;
        private string title;
        private double price;

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                string[] authorNames = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (Char.IsDigit(authorNames[1][0])) { throw new ArgumentException("Author not Valid!"); }
                this.author = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if(value.Length < 3) { throw new ArgumentException("Title not valid!"); }
                this.title = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value <= 0) { throw new ArgumentException("Price not valid!"); }
                this.price = value;
            }
        }

        public Book(string author, string title, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            string classString = $"Type: {this.GetType().Name}, Author: {this.Author}, Title: {this.Title}, Price: {this.Price}";
            return classString;
        }
    }
}
