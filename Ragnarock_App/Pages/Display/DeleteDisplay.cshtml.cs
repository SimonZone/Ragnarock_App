using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ragnarock_App.Model;
using Ragnarock_App.Repository;

namespace Ragnarock_App
{
    public class DeleteDisplayModel : PageModel
    {
        [BindProperty]
        public Display display { get; set; }
        private IDisplayRepository catalog;
        public DeleteDisplayModel(IDisplayRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet(int id)
        {
            display = catalog.GetDisplay(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            catalog.DeleteDisplay(id);
            return RedirectToPage("GetAllDisplays");
        }
    }
}
