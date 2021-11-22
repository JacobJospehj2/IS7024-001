using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;
using Breweries;
using DetailBrewery;
using System.Collections.Generic;
using System;

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
                    string BreweriesData = string.Empty;
                    try
                    {
                        BreweriesData = webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error during API call - Breweries", e);

                    }
                    List<BreweryCollection> breweryCollections = BreweryCollection.FromJson(BreweriesData);
                    ViewData["BreweryCollection"] = breweryCollections;

                    string jsonStringDetails = webClient.DownloadString("https://api.openbrewerydb.org/breweries/10-56-brewing-company-knox");


                    Brewery detailBrewery = Brewery.FromJson(json: jsonStringDetails);

                    ViewData["Brewery"] = detailBrewery;

                    
                }
            }
        }
    }

}
