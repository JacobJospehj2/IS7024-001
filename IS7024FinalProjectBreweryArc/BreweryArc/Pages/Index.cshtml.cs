﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;
using Breweries;
using DetailBrewery;
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
            if (brandName == null || brandName.Length == 0)
            {
                brandName = "Brewery Arc";
            }
            ViewData["brandName"] = brandName + yearStarted;
            {
                using (var webClient = new WebClient())
                {
                    // Grab our JSON text.
                    string jsonString = webClient.DownloadString("https://api.openbrewerydb.org/breweries");

                    // Convert raw text to objects.
                    List<BreweryCollection> breweryCollections = BreweryCollection.FromJson(jsonString);

                    //Getting data of all Brewery
                    ViewData["BreweryCollection"] = breweryCollections;


                    // grab our JSON text.
                    string jsonStringDetails = webClient.DownloadString("https://api.openbrewerydb.org/breweries/10-56-brewing-company-knox");

                    // convert raw text to objects.
                    Brewery detailBrewery = Brewery.FromJson(json: jsonStringDetails);

                    //Getting data of all Brewery
                    ViewData["Brewery"] = detailBrewery;
                }
            }
        }
    }

}
