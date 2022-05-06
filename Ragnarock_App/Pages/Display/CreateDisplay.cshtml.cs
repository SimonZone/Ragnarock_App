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
    public class CreateDisplayModel : PageModel
    {
        [BindProperty]
        public Display display { get; set; }
        private IDisplayRepository catalog;
        public CreateDisplayModel(IDisplayRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            catalog.AddDisplay(display);

            return RedirectToPage("GetAllDisplays");
        }
    }
}
