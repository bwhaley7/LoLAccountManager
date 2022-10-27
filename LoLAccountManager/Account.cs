using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAccountManager
{
    public class Account
    {
        [JsonProperty]
        public string user { get; set; }
        [JsonProperty]
        public string pass { get; set; }
        [JsonProperty]
        public string rank { get; set; }

        public Account()
        {

        }
        public Account(string usr, string ps, string rnk)
        {
            user = usr;
            pass = ps;
            rank = rnk;
        }
    }
}
