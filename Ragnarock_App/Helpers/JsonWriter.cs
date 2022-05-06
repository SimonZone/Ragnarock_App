using Newtonsoft.Json;
using Ragnarock_App.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ragnarock_App.Helpers
{
    public class JsonWriter
    {
        public static void WriteToJson(Dictionary<int, Display> pizzas, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(pizzas, Formatting.Indented);

            File.WriteAllText(JsonFileName, output);
        }
    }
}
