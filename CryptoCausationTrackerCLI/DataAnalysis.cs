using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCausationTrackerCLI
{
    class DataAnalysis
    {

        public static double GetTotalPrice()
        {
            double intTotalPrice = 0;
            double intCurrentPrice = 0;

            for (int index = 0; index < Program.msgListOfSearchedMessages.Count; index++)
            {
                intCurrentPrice = double.Parse(Program.msgListOfSearchedMessages[index].price);
                intTotalPrice = intTotalPrice + intCurrentPrice;
            }

            return intTotalPrice;
        }

        public static double GetAveragePrice()
        {
            double intAveragePrice = 0;
            double intAmountOfPrices = 0;

            intAmountOfPrices = Program.msgListOfSearchedMessages.Count;
            intAveragePrice = GetTotalPrice() / intAmountOfPrices;

            return intAveragePrice;
        }

        public static void SearchMessages(String strCryptoCurrencyType, String strBaseCurrencyType, int intIndexOfForLoop)
        {
            if ((Program.msgListOfMessages[intIndexOfForLoop].cryptocurrency == strCryptoCurrencyType) && (Program.msgListOfMessages[intIndexOfForLoop].basecurrency == strBaseCurrencyType))
            {
                Program.msgListOfSearchedMessages.Add(Program.msgListOfMessages[intIndexOfForLoop]);
            }
        }

    }
}
