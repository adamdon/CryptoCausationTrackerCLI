using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Satori.Rtm;
using Satori.Rtm.Client;
using System.IO;
using System.Runtime.Serialization.Json;

namespace CryptoCausationTrackerCLI
{
    class Program
    {
        const string endpoint = "wss://open-data.api.satori.com";
        const string appkey = "08887F4cC5Fb788f899F3bc2bF2deA75";
        const string channel = "cryptocurrency-market-data";

        static void Main()
        {
            int intIndexOfForLoop = 0;

            // DataStorage.strCryptoCurrencySearchCriteria = View.DrawStartScreen(); //turn off for debug

            Trace.Listeners.Add(new ConsoleTraceListener());
            IRtmClient client = new RtmClientBuilder(endpoint, appkey).Build();
            client.OnEnterConnected += cn => Console.WriteLine("Connected to Data Steam");
            client.Start();
            var observer = new SubscriptionObserver();

            observer.OnSubscriptionData += (ISubscription sub, RtmSubscriptionData data) =>
            {
                foreach (JToken msg in data.Messages)
                {
                    Message msgTempMessage = new Message(ReadToObject(msg.ToString()));

                    Controller.Loop(msgTempMessage, intIndexOfForLoop);

                    intIndexOfForLoop = intIndexOfForLoop + 1;
                }
            };

            
            client.CreateSubscription(channel, SubscriptionModes.Simple, observer);
            Console.ReadKey();
            client.Dispose().Wait();
        }


        public static Message ReadToObject(string json)
        {
            Message deserializedMessage = new Message();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedMessage.GetType());
            deserializedMessage = ser.ReadObject(ms) as Message;
            ms.Close();
            return deserializedMessage;
        }




    }
}
