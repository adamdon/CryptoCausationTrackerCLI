using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCausationTrackerCLI
{
    class View
    {
         public static void Update(int intIndexOfForLoop)
        {
            if((intIndexOfForLoop % 10) == 0 && (intIndexOfForLoop > 10))
            {
                Draw(intIndexOfForLoop);
            }
            


        }
        public static void Draw(int intIndexOfForLoop)
        {
            Console.Clear();
            Console.WriteLine("##############################");
            Console.Write("#  ");
            Console.WriteLine("Coin: : " + Program.msgListOfMessages[intIndexOfForLoop].cryptocurrency + " ");
            Console.Write("#  ");
            Console.WriteLine("Price: : " + Program.msgListOfMessages[intIndexOfForLoop].price + " ");
            Console.Write("#  ");
            Console.WriteLine("Avg ETH/USD price: : " + GetAveragePrice(GetTotalPrice()) + " ");
            Console.WriteLine("##############################");
        }

        public static double GetTotalPrice()
        {
            double intTotalPrice = 0;
            double intCurrentPrice = 0;

            for (int index = 0; index < Program.msgListOfSearchedMessages.Count; index++ )
            {
                intCurrentPrice = double.Parse(Program.msgListOfSearchedMessages[index].price);
                intTotalPrice = intTotalPrice + intCurrentPrice;
            }

            return intTotalPrice;
        }

        public static double GetAveragePrice(double intTotalPrice)
        {
            double intAveragePrice = 0;
            double intAmountOfPrices = 0;

            intAmountOfPrices = Program.msgListOfSearchedMessages.Count;
            intAveragePrice = intTotalPrice / intAmountOfPrices;

            return intAveragePrice;
        }






    }


}
