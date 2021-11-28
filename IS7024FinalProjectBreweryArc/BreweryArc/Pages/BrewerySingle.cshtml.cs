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

            InitStateDropdown();
            using (var webClient = new WebClient())


            {
                                
                {

                    string json_String = webClient.DownloadString($"https://api.openbrewerydb.org/breweries/{id}") ;
                    var Brewery_details = BreweriesSingleData.BreweriesSingleCollection.FromJson(json_String);

                           var abc = string.IsNullOrWhiteSpace(id);
                           if (!abc)

                    //       var Brewery_detailsList = Brewery_details.ToList();
                    //       var IdWiseBrewerydetails = Brewery_detailsList.FindAll(x => string.Equals(x.Id.ToString(), query, StringComparison.OrdinalIgnoreCase));

                    if (Brewery_details.Id != null)
                    {
                        ViewData["Brewery_details"] = Brewery_details;
                        
                    }
                    else
                    {
                        ViewData["Brewery_details"] = null;
                    }
          //      }
          //          else
          //          {
           //             ViewData["Brewery_details"] = null;
           //         }

                  
                }
                SearchId = id;
            }
        }

        private void InitStateDropdown()
        {
            var Count_list = new List<string>
         {
             { "10-56-brewing-company-knox" },
             { "10-barrel-brewing-co-bend-1" },
             { "10-barrel-brewing-co-bend-2" },
             { "10-barrel-brewing-co-boise-boise" },
             { "10-barrel-brewing-co-bend-pub-bend" },
             { "10-barrel-brewing-co-denver-denver" },
             { "10-barrel-brewing-co-portland" },
             { "10-barrel-brewing-co-san-diego" },
             {"10-torr-distilling-and-brewing-reno" },
             {"101-brewery-quilcene" },
             {"101-north-brewing-company-petaluma" },
             {"105-west-brewing-co-castle-rock" },
             {"10k-brewing-anoka" },
             {"10th-district-brewing-company-abington" },
             {"11-below-brewing-company-houston" },
             {"1188-brewing-co-john-day" },
             {"12-acres-brewing-company-killeshin" },
             {"12-gates-brewing-company-williamsville" },
             {"12-west-brewing-company-gilbert" },
             {"12-west-brewing-company-production-facility-mesa" }


        };


            ViewData["SearchId"] = new SelectList(Count_list);
        }
    }
}

