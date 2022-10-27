using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoLAccountManager
{
    public static class JsonFileUtils
    {
        public static void JsonWrite(object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(fileName, jsonString);
        }

        public static List<Account> JsonRead(List<Account> obj, string fileName)
        {
            string json = File.ReadAllText(fileName);
            obj = JsonConvert.DeserializeObject<List<Account>>(json);
            return obj;
        }
    }
}
