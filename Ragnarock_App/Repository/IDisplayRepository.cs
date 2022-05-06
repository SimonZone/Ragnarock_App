using Ragnarock_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ragnarock_App.Repository
{
    public interface IDisplayRepository
    {
        Dictionary<int, Display> AllDisplays();
        Dictionary<int, Display> FilterDisplay(string crtiteria);
        void DeleteDisplay(int id);
        void AddDisplay(Display display);
        void UpdateDisplay(Display display);
        Display GetDisplay(int id);
    }
}
