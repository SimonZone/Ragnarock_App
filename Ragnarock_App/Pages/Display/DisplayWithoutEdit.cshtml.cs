using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ragnarock_App.Repository;
using Ragnarock_App.Model;

namespace Ragnarock_App
{
    public class DisplayWithoutEditModel : PageModel
    {
        private IDisplayRepository catalog;
        public DisplayWithoutEditModel(IDisplayRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<int, Display> displays { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public IActionResult OnGet()
        {
            displays = catalog.AllDisplays();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                displays = catalog.FilterDisplay(FilterCriteria);
            }

            return Page();
        }
    }
}
