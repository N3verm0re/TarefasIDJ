using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBookShop
{
    public class GoldenEditionBook : Book
    {
        public override double Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                if(value <= 0) { throw new ArgumentException("Price not valid!"); }
                base.Price = value * 1.30;
            }
        }

        public GoldenEditionBook(string author, string title, double price) : base(author, title, price) { }
    }
}
