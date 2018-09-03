using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCausationTrackerCLI
{
    class Controller
    {
        public static void Loop(Message msgIncommingMessage, int intIndexOfForLoop)
        {
            DataStorage.msgListOfMessages.Insert(intIndexOfForLoop, msgIncommingMessage);
            DataStorage.UpdateSearch(DataAnalysis.SearchMessages(DataStorage.strCryptoCurrencySearchCriteria, DataStorage.strBaseCurrencySearchCriteria, intIndexOfForLoop), intIndexOfForLoop);

            if ((intIndexOfForLoop % 5) == 0 && (intIndexOfForLoop > 10))
            {
                View.Update(intIndexOfForLoop);
            }
            
        }

        //public static void StartUp()
        //{

        //}

    }
}
