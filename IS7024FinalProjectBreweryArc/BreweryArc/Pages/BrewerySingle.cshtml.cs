using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace BreweriesSingle.Pages
{

    public class BreweriesSingleModel : PageModel
    {
        public SelectList IdList { get; set; }
        public string SearchId { get; set; }
        public List<string> Count_list { get; set; }
        public void OnGetAsync(string id)
        {

            using (var webClient = new WebClient())

            {               
                {
                    string json_String = webClient.DownloadString($"https://api.openbrewerydb.org/breweries/{id}") ; // Dynamically Implementing the 2nd API
                    var Brewery_details = BreweriesSingleData.BreweriesSingleCollection.FromJson(json_String);

                    if (Brewery_details.Id != null)
                    {
                        ViewData["Brewery_details"] = Brewery_details;
                        
                    }
                    else
                    {
                        ViewData["Brewery_details"] = null;
                    }
                  
                }
                SearchId = id;
            }
        }
        
    }
}

