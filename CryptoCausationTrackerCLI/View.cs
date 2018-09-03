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
                DrawDataOutput(intIndexOfForLoop);
            }
            


        }
        public static void DrawDataOutput(int intIndexOfForLoop)
        {
            Console.Clear();
            Console.WriteLine("##############################");
            Console.Write("#  ");
            Console.WriteLine("Coin: : " + Program.msgListOfMessages[intIndexOfForLoop].cryptocurrency + " ");
            Console.Write("#  ");
            Console.WriteLine("Price: : " + Program.msgListOfMessages[intIndexOfForLoop].price + " ");
            Console.Write("#  ");
            Console.WriteLine("Avg ETH/USD price: : " + DataAnalysis.GetAveragePrice() + " ");
            Console.WriteLine("##############################");
            Console.Write("#  ");
            Console.WriteLine("Trades Processed : " + intIndexOfForLoop + " ");
            Console.WriteLine("##############################");
        }

        public static void DrawStartScreen()
        {
            Console.Clear();
            Console.WriteLine("##############################");
            Console.Write("#  ");
            Console.WriteLine("");
        }



   

    }


}
