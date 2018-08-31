using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCausationTrackerCLI
{

    public class Message
    {
        public string exchange { get; set; }
        public string cryptocurrency { get; set; }
        public string basecurrency { get; set; }
        public string type { get; set; }
        public string price { get; set; }
        public object size { get; set; }
        public string bid { get; set; }
        public string ask { get; set; }
        public object open { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string volume { get; set; }
        public string timestamp { get; set; }

        public Message()
        {

        }

        public Message(Message msgGet)
        {
            exchange = msgGet.exchange;
            cryptocurrency = msgGet.cryptocurrency;
            basecurrency = msgGet.basecurrency;
            type = msgGet.type;
            price = msgGet.price;
            size = msgGet.size;
            bid = msgGet.bid;
            ask = msgGet.ask;
            open = msgGet.open;
            high = msgGet.high;
            low = msgGet.low;
            volume = msgGet.volume;
            timestamp = msgGet.timestamp;


        }

        public Message(string exchangeP, string cryptocurrencyP, string basecurrencyP, string typeP, string priceP,
        object sizeP, string bidP, string askP, object openP, string highP, string lowP, string volumeP, string timestampP)
        {
           exchange = exchangeP;
           cryptocurrency = cryptocurrencyP;
           basecurrency = basecurrencyP;
           type = typeP;
           price = priceP;
           size = sizeP;
           bid = bidP;
           ask = askP;
           open = openP;
           high = highP;
           low = lowP;
           volume = volumeP;
           timestamp = timestampP;

        }
    }

}
