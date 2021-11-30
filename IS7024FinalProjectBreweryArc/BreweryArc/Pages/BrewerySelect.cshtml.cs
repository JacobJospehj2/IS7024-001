using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BrewerySelect.Pages
{
    public class BreweriesSelect : PageModel
    {
        public SelectList BreweriesList { get; set; }
        public string Type1 { get; set; }
        public List<string> Count_list { get; set; }
        public void OnGetAsync(string query)
        {

            InitStateDropdown();
            using (var webClient = new WebClient())

            {

                string jsonString = webClient.DownloadString("https://api.openbrewerydb.org/breweries");

                var Brewery_Select = Breweries.BreweryCollection.FromJson(jsonString);


                if (!string.IsNullOrWhiteSpace(query))
                {
                    var Brewery_SelectList = Brewery_Select.ToList();

                    var typeWiseBrewerydetails = Brewery_SelectList.FindAll(x => string.Equals(x.Id.ToString(), query, StringComparison.OrdinalIgnoreCase));


                    if (typeWiseBrewerydetails != null && typeWiseBrewerydetails.Count > 0)
                    {
                        ViewData["Brewery_Select"] = typeWiseBrewerydetails;
                    }
                    else
                    {
                        ViewData["Brewery_Select"] = null;
                    }
                }
                else
                {
                    ViewData["Brewery_Select"] = null;
                }

                Type1 = query;

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
            ViewData["Type1"] = new SelectList(Count_list);
        }
    }
}
