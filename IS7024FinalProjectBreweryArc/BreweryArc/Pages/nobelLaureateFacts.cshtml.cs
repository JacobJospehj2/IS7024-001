using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NobelLaureates.Pages
{
    public class nobelLaureateFactsModel : PageModel
    {
        public SelectList CountryList { get; set; }
        public string SearchCountry { get; set; }
        public List<string> CountList { get; set; }

        public void OnGetAsync(string query)
        {
            InitStateDropdown();
            using (var webClient = new WebClient())


            {

                string laureateJson = webClient.DownloadString("http://api.nobelprize.org/v1/laureate.json");
                var laureateDetails = QuickTypeNobelLaureates.NobelLaureates.FromJson(laureateJson);

                if (!string.IsNullOrWhiteSpace(query))
                {
                    var lauretList = laureateDetails.Laureates;
                    var countryWiseLauretList = lauretList.FindAll(x => string.Equals(x.BornCountry, query, StringComparison.OrdinalIgnoreCase));
                    if (countryWiseLauretList != null && countryWiseLauretList.Count > 0)
                    {
                        ViewData["LaureateDetails"] = countryWiseLauretList;
                    }
                    else
                    {
                        ViewData["LaureateDetails"] = null;
                    }
                }
                else
                {
                    ViewData["LaureateDetails"] = null;
                }

                SearchCountry = query;

            }
        }

        private void InitStateDropdown()
        {
            var CountList = new List<string>
            {
             { "Denmark" },
             { "Germany"},
             { "India" }


            };

            ViewData["SearchCountry"] = new SelectList(CountList);
        }
    }

}