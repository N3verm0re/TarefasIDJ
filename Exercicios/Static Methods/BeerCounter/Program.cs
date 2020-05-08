using System;

namespace BeerCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int beersBought = 0;
            int beersDrunk = 0;

            while (command != "End")
            {
                string[] splits = command.Split(' ');
                beersBought = Int32.Parse(splits[0]);
                beersDrunk = Int32.Parse(splits[1]);

                BeerCounter.BuyBeer(beersBought);
                BeerCounter.DrinkBeer(beersDrunk);
                command = Console.ReadLine();
            }

            Console.WriteLine("Beers remaining in Stock : {0}, Beers Drunk: {1}", BeerCounter.beerInStock, BeerCounter.beerDrankCount);
        }
    }
}
