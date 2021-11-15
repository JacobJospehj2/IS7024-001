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
                    // grab our JSON text.
                    string Brewery_data = string.Empty;
                    



                    try
                    {
                        Brewery_data = webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception while calling API", e);



                    }
                    

                    // convert raw text to objects.
                    List<BreweryCollection> breweryCollections = BreweryCollection.FromJson(Brewery_data);

                    //Getting data of all Brewery
                    ViewData["BreweryCollection"] = breweryCollections;


                    // grab our JSON text.
                    string detailBrewery = string.Empty;
                   



                    try
                    {
                        detailBrewery = webClient.DownloadString("https://api.openbrewerydb.org/breweries/10-56-brewing-company-knox");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception while calling API", e);



                    }
                    

                    // convert raw text to objects.
                    Brewery detailsofBrewery = Brewery.FromJson(json: detailBrewery);

                    //Getting data of all Brewery
                    ViewData["Brewery"] = detailsofBrewery;

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
