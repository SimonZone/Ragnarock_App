using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Ragnarock_App.Pages
{
    public class Om_osModel : PageModel
    {
        private readonly ILogger<Om_osModel> _logger;

        public Om_osModel(ILogger<Om_osModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
