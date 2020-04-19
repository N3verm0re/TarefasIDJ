using System;

namespace InheritanceBookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insert Author:");
                string author = Console.ReadLine();
                Console.WriteLine("Insert Title:");
                string title = Console.ReadLine();
                Console.WriteLine("Insert Price:");
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
