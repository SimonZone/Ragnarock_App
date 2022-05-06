﻿using Ragnarock_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ragnarock_App.Repository;

namespace Ragnarock_App.Services
{
    public class DisplayCalatog : IDisplayRepository
    {
        Dictionary<int, Display> displays { get; }


        public DisplayCalatog()
        {
            displays = new Dictionary<int, Display>();
            displays.Add(1, new Display() { Id = 1, Name = "Beggin", Description = "By måneskin", SoundFile = "beggin.mp3" });
            displays.Add(2, new Display() { Id = 2, Name = "Starlight", Description = "Dave", SoundFile = "Starlight.mp3" });
            displays.Add(3, new Display() { Id = 3, Name = "Enemy", Description = "Image dragons", SoundFile = "Enemy.mp3" });
        }

        public Dictionary<int, Display> AllDisplays()
        {
            return displays;
        }
        public void AddDisplay(Display display)
        {
            if (!(displays.Keys.Contains(display.Id)))
                displays.Add(display.Id, display);
        }

        public Dictionary<int, Display> FilterDisplay(string criteria)
        {
            Dictionary<int, Display> myDisplays = new Dictionary<int, Display>();
            if (criteria != null)
            {
                foreach (var d in displays.Values)
                {
                    if (d.Name.StartsWith(criteria))
                    {
                        myDisplays.Add(d.Id, d);
                    }
                }
            }
            return myDisplays;
        }

        public Display GetDisplay(int id)
        {
            return displays[id];
        }

        public void UpdateDisplay(Display pizza)
        {
            displays[pizza.Id] = pizza;
        }

        public void DeleteDisplay(int id)
        {
            displays.Remove(id);
        }
    }
}