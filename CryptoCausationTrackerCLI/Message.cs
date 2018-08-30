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
    }

}
