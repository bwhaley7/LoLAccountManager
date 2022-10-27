using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoLAccountManager
{
    class RequestHandler
    {
        private static readonly HttpClient client = new HttpClient();
        private const string RANK_URL = "https://www.op.gg/summoners/na/{0}";
        private const string AUTH_URL = "https://auth.riotgames.com/api/v1/authorization";
        private const string INFO_URL = "https://auth.riotgames.com/userinfo";
    }
}
