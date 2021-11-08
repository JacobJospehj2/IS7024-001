﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;
using Breweries;
using System.Collections.Generic;

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
            string brandName = Request.Query["BrandName"];
            int yearStarted = 2006;
          
            ViewData["brandName"] = brandName + yearStarted;
            {
            using (var webClient = new WebClient())
            {
                // grab our JSON text.
                string jsonString = webClient.DownloadString("https://api.openbrewerydb.org/breweries");

                // convert raw text to objects.
                List<BreweryCollection> breweryCollections = BreweryCollection.FromJson(jsonString);

                //Getting data of all Brewery
                ViewData["BreweryCollection"] = breweryCollections;

                //JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("BreweryArc.json"));
                //JArray Array = JArray.Parse(jsonString);
                //IList<string> validationEevnts = new List<string>();
                //if (jsonObject.IsValid(schema, out validationEevnts))
                //{
                //    var breweries = Breweries.FromJson(jsonString);
                //    ViewData["Breweries"] = breweries;
                //} 
                //else
                //{
                //    foreach(string evt in validationEevnts)
                //    {
                //        Console.WriteLine(evt);
                //    }
                //    ViewData["Breweries"] = new List<Breweries>();
                }
            }
        }
    }
}
