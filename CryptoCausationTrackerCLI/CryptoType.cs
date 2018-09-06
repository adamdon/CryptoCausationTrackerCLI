using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCausationTrackerCLI
{
    class CryptoType
    {
        public string strCryptoTypeName { get; set; }
        public int intNumberOfOccurrences { get; set; }

        public CryptoType(string strCryptoTypeNameP, int intNumberOfOccurrencesP)
        {
            strCryptoTypeName = strCryptoTypeNameP;
            intNumberOfOccurrences = intNumberOfOccurrencesP;
            
        }

    }
}
