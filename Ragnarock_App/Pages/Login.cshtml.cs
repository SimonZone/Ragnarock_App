using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Ragnarock_App.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public string Brugernavn { get; set; }

        [BindProperty]
        public string Adgangskode { get; set; }

        public string Msg { get; set; }

        bool LoggediIn = false;


        public IActionResult OnPost()
        {
            if (Brugernavn.Equals("RDP") && Adgangskode.Equals("4444"))
            {
                HttpContext.Session.SetString("Brugernavn", Brugernavn);
                LoggediIn = true;
                return RedirectToPage("Display/GetAllDisplays");
            }
            else
            {
                Msg = "Fejl";
                return Page();
            }
        }


      
    }
}
