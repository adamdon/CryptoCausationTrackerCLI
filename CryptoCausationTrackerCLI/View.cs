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
            DrawDataOutput(intIndexOfForLoop);

        }

        public static void DrawDataOutput(int intIndexOfForLoop)
        {
            Console.Clear();
            Console.WriteLine("##############################");
            Console.Write("#  ");
            Console.WriteLine("Coin: : " + DataStorage.msgListOfMessages[intIndexOfForLoop].cryptocurrency + " ");
            Console.Write("#  ");
            Console.WriteLine("Price: : " + DataStorage.msgListOfMessages[intIndexOfForLoop].price + " ");
            Console.Write("#  ");
            Console.WriteLine("Avg ETH/USD price: : " + DataAnalysis.GetAveragePrice() + " ");
            Console.Write("#  ");
            Console.WriteLine("Number of ETH trades: : " + DataAnalysis.GetCryptoTypeOccurrences(DataStorage.strCryptoCurrencySearchCriteria) + " ");
            Console.WriteLine("##############################");
            Console.Write("#  ");
            Console.WriteLine("Trades Processed : " + intIndexOfForLoop + " ");
            Console.WriteLine("##############################");
        }

        public static string DrawStartScreen()
        {
            String strInputedCryptoType;

            Console.Clear();
            Console.WriteLine("##############################");
            Console.Write("#  ");
            Console.WriteLine("Please input Type of Crypto type (e.g ETH or BTC)");
            strInputedCryptoType = Console.ReadLine();
            Console.WriteLine("##############################");

            return strInputedCryptoType;
        }



   

    }


}
