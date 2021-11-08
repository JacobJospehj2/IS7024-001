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
using Newtonsoft.Json.Linq;

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
                JObject jsonObject = JObject.Parse(jsonString);
                IList<string> validationEevnts = new List<string>();
                if (jsonObject.IsValid(schema, out validationEevnts))
                {
                    var breweries = Breweries.FromJson(jsonString);
                    ViewData["Breweries"] = breweries;
                } 
                else
                {
                    foreach(string evt in validationEevnts)
                    {
                        Console.WriteLine(evt);
                    }
                    ViewData["Breweries"] = new List<Breweries>();
                }
            }
        }
    }
}
