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
            if((intIndexOfForLoop % 10) == 0)
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

            Console.WriteLine("##############################");
        }




    }


}
