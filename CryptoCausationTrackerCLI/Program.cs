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

        static string strOutputText = "Error1";
        string strType;

        static void Main()
        {
            // Log messages from SDK to the console
            Trace.Listeners.Add(new ConsoleTraceListener());

            IRtmClient client = new RtmClientBuilder(endpoint, appkey).Build();
            client.OnEnterConnected += cn => Console.WriteLine("Connected to Satori RTM!");
            client.Start();

            // Create subscription observer to observe channel subscription events 
            var observer = new SubscriptionObserver();

            observer.OnSubscriptionData += (ISubscription sub, RtmSubscriptionData data) =>
            {
                foreach (JToken msg in data.Messages)
                {
                    //Console.WriteLine("Got message: " + msg);
                    strOutputText = msg.ToString();
                    Console.WriteLine("Coin: " + ReadToObject(strOutputText).cryptocurrency);
                    Console.WriteLine("Price: " + ReadToObject(strOutputText).price);
                    //strType
                    //new Message = ReadToObject(strOutputText);
                }
            };

            Console.WriteLine("Test end of forloop");
            client.CreateSubscription(channel, SubscriptionModes.Simple, observer);

            Console.ReadKey();

            // Stop and clean up the client before exiting the program
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
