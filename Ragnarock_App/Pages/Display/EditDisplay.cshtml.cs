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
    public class EditDisplayModel : PageModel
    {
        [BindProperty]
        public Display display { get; set; }
        private IDisplayRepository catalog;
        public EditDisplayModel(IDisplayRepository repository)
        {
            catalog = repository;
        }
        public void OnGet(int id)
        {
            display = catalog.GetDisplay(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdateDisplay(display);
            return RedirectToPage("GetAllDisplays");
        }
    }
}
