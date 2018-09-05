using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCausationTrackerCLI
{
    class DataStorage
    {
        public static List<Message> msgListOfMessages = new List<Message>();
        public static List<Message> msgListOfSearchedMessages = new List<Message>();

        public static string strCryptoCurrencySearchCriteria = "ETH";
        public static string strBaseCurrencySearchCriteria = "USD";

        public static List<string> strCryptoTypesArray = new List<string>();


        public static void UpdateSearch(bool isSearchResults, int intIndexOfForLoop)
        {
            if (isSearchResults == true)
            {
                msgListOfSearchedMessages.Add(msgListOfMessages[intIndexOfForLoop]);
            }

        }

        //public static void UpdateCryptoTypes(int intIndexOfForLoop)
        //{
        //    string strTempCryptoType = DataStorage.msgListOfMessages[intIndexOfForLoop].cryptocurrency;

        //    if (DataAnalysis.IsCryptoTypeNew(strTempCryptoType) == true)
        //    {
        //        strCryptoTypesArray.Add(strTempCryptoType);
        //    }
        //}


    }
}
