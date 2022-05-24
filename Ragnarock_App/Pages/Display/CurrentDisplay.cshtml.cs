using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ragnarock_App.Model;
using Ragnarock_App.Repository;
using Microsoft.AspNetCore.Http;

namespace Ragnarock_App
{
    public class CurrentDisplayModel : PageModel
    {
        public string Brugernavn { get; set; }
       

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Brugernavn");
            return RedirectToPage("Hjem");
        }
        [BindProperty]
        public Display display { get; set; }
        private IDisplayRepository catalog;
        public CurrentDisplayModel(IDisplayRepository repository)
        {
            catalog = repository;
        }
        public void OnGet(int id)
        {
            display = catalog.GetDisplay(id);
            Brugernavn = HttpContext.Session.GetString("Brugernavn");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdateDisplayRating(display);
            return RedirectToPage("GetAllDisplays");

        }
    }
}
