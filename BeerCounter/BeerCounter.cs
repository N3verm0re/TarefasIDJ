using System;
using System.Collections.Generic;
using System.Text;

namespace BeerCounter
{
    class BeerCounter
    {
        public static int beerInStock = 0;
        public static int beerDrankCount = 0;


        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            if (beerInStock != 0 && beerInStock >= bottlesCount)
            {
                beerInStock -= bottlesCount;
                beerDrankCount += bottlesCount;
            }
            else //If there are less beers in stock than the ones being requested to drink, drink all available beers and turn stock to 0
            {
                beerDrankCount += beerInStock;
                beerInStock = 0;
            }
        }
    }
}
