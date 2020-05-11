using System;
using System.Collections.Generic;
using WeaponSystem;

namespace ConfigureManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Load if you wish to load and edit an existing Json with Manufacturers or Type New to create a new list of Manufacturers. Type Exit to leave the program.");
            string firstCommand = Console.ReadLine();

            while(firstCommand.ToLower() != "exit")
            {
                if (firstCommand.ToLower() == "load")
                {
                    //TODO Implement loading of file 
                    //TODO Implement editing of file
                }
                else if (firstCommand.ToLower() == "new")
                {
                    Dictionary<string, ManufacturerBase> manufacturerList = new Dictionary<string, ManufacturerBase>();
                    //TODO Implement creation of Manufacturers
                    //TODO Implement saving file
                }
                else
                {
                    Console.WriteLine("Invalid command, try again");
                }

                firstCommand = Console.ReadLine();
            }
        }
    }
}
