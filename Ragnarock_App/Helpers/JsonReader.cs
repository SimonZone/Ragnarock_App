using Newtonsoft.Json;
using Ragnarock_App.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ragnarock_App.Helpers
{
    public class JsonReader
    {
        public static Dictionary<int, Display> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<Dictionary<int, Display>>(jsonString);
        }
    }
}
