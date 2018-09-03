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

            for (int index = 0; index < DataStorage.msgListOfSearchedMessages.Count; index++)
            {
                intCurrentPrice = double.Parse(DataStorage.msgListOfSearchedMessages[index].price);
                intTotalPrice = intTotalPrice + intCurrentPrice;
            }

            return intTotalPrice;
        }

        public static double GetAveragePrice()
        {
            double intAveragePrice = 0;
            double intAmountOfPrices = 0;

            intAmountOfPrices = DataStorage.msgListOfSearchedMessages.Count;
            intAveragePrice = GetTotalPrice() / intAmountOfPrices;
            intAveragePrice = Math.Round(intAveragePrice, 2);

            return intAveragePrice;
        }

        public static int GetCryptoTypeOccurrences(string strBaseCurrencySearchCriteria)
        {
            int intNumberOfOccurrences = 0;

            for (int index = 0; index < DataStorage.msgListOfMessages.Count; index++)
            {
                if (DataStorage.msgListOfMessages[index].cryptocurrency == strBaseCurrencySearchCriteria)
                {
                    intNumberOfOccurrences = intNumberOfOccurrences + 1;
                }
            }

            return intNumberOfOccurrences;
        }



        public static bool SearchMessages(String strCryptoCurrencyType, String strBaseCurrencyType, int intIndexOfForLoop)
        {
            if ((DataStorage.msgListOfMessages[intIndexOfForLoop].cryptocurrency == strCryptoCurrencyType) && (DataStorage.msgListOfMessages[intIndexOfForLoop].basecurrency == strBaseCurrencyType))
            {
                return true;
            }
            return false;
        }

    }
}
