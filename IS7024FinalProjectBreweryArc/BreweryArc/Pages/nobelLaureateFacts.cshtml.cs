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
        public List<string> Count_list { get; set; }

        public void OnGetAsync(string query)
        {
            InitStateDropdown();
            using (var webClient = new WebClient())


            {

                string json_String = webClient.DownloadString("http://api.nobelprize.org/v1/laureate.json");
                var Laureate_details = QuickTypeNobelLaureates.NobelLaureates.FromJson(json_String);

                if (!string.IsNullOrWhiteSpace(query))
                {
                    var LauretList = Laureate_details.Laureates;
                    var countryWiseLauretList = LauretList.FindAll(x => string.Equals(x.BornCountry, query, StringComparison.OrdinalIgnoreCase));
                    if (countryWiseLauretList != null && countryWiseLauretList.Count > 0)
                    {
                        ViewData["Laureate_details"] = countryWiseLauretList;
                    }
                    else
                    {
                        ViewData["Laureate_details"] = null;
                    }
                }
                else
                {
                    ViewData["Laureate_details"] = null;
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
             { "Ireland" },
             { "Luxembourg" }


            };

            ViewData["SearchCountry"] = new SelectList(Count_list);
        }
    }

}