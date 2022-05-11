using Ragnarock_App.Helpers;
using Ragnarock_App.Model;
using Ragnarock_App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ragnarock_App.Services
{
    public class DisplayJson : IDisplayRepository
    {
        string JsonFileName = @"wwwroot\Json\Displayjson.json";

        public void AddDisplay(Display display)
        {
            Dictionary<int, Display> displays = AllDisplays();
            displays.Add(display.Id, display);
            JsonWriter.WriteToJson(displays, JsonFileName);
        }

        public Dictionary<int, Display> AllDisplays()
        {
            return JsonReader.ReadJson(JsonFileName);
        }
        public Dictionary<int, Display> FilterDisplay(string criteria)
        {
            Dictionary<int, Display> displays = AllDisplays();
            Dictionary<int, Display> filteredDisplay = new Dictionary<int, Display>();
            foreach (var d in displays.Values)
            {
                if (d.Name.StartsWith(criteria))
                {
                    filteredDisplay.Add(d.Id, d);
                }
            }
            return filteredDisplay;
        }

        public Display GetDisplay(int id)
        {
            Dictionary<int, Display> displays = AllDisplays();
            Display foundDisplay = displays[id];
            return foundDisplay;
        }

        public void UpdateDisplay(Display display)
        {
            Dictionary<int, Display> Displays = AllDisplays();
            Display foundDisplay = Displays[display.Id];
            foundDisplay.Id = display.Id;
            foundDisplay.Name = display.Name;
            foundDisplay.Description = display.Description;
            foundDisplay.DisplayText = display.DisplayText;
            foundDisplay.ImageFile = display.ImageFile;
            foundDisplay.SoundFile = display.SoundFile;
            JsonWriter.WriteToJson(Displays, JsonFileName);
        }

        public void DeleteDisplay(int id)
        {
            Dictionary<int, Display> displays = AllDisplays();
            displays.Remove(id);
            JsonWriter.WriteToJson(displays, JsonFileName);
        }
    }
}
