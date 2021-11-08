using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickType;
using System.Net;
using Newtonsoft.Json.Schema;

namespace BreweryArc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string jsonString = webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("BreweryArc.json"));
                var breweries = Breweries.FromJson(jsonString);
                ViewData["Breweries"] = breweries;
            }
        }
    }
}
