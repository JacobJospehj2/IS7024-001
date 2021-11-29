using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BreweryEntire.Pages
{
    public class BreweryEntire : PageModel
    {
        public JsonResult OnGet()
        {
            using (var webClient = new WebClient())
            {
                string jsonEntire = webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                return new JsonResult(jsonEntire);
            }
        }
    }
}
