using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BreweryArc.Pages
{
    public class BreweriesModel : PageModel
    {
        public SelectList CountryList { get; set; }
        public string SearchCountry { get; set; }
        public List<string> Count_list { get; set; }
        public void OnGet(string query)
        {

            InitStateDropdown();
            using (var webClient = new WebClient())
              
            {
                
                string jsonString = webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                var Brewery_details = Breweries.BreweryCollection.FromJson(jsonString);



                if (!string.IsNullOrWhiteSpace(query))
                {
                    var Brewery_detailsList = Brewery_details.ToList();
                    var countryWiseBrewerydetails = Brewery_detailsList.FindAll(x => string.Equals(x.Country.ToString(), query, StringComparison.OrdinalIgnoreCase));
                    if (countryWiseBrewerydetails != null && countryWiseBrewerydetails.Count > 0)
                    {
                        var orderedcountryWiseBrewerydetails = countryWiseBrewerydetails.OrderByDescending(x => x.CreatedAt).ToArray();
                        ViewData["Brewery_details"] = orderedcountryWiseBrewerydetails[0];
                    }
                    else
                    {
                        ViewData["Brewery_details"] = null;
                    }
                }
                else
                {
                    ViewData["Brewery_details"] = null;
                }

                SearchCountry = query;
            }
        }

        private void InitStateDropdown()
        {
            var Count_list = new List<string>
            {
                { "India" },
                { "Canada" },
                { "United States" },
                { "Ireland" }


        };


            ViewData["SearchCountry"] = new SelectList(Count_list);
        }
    }
}
