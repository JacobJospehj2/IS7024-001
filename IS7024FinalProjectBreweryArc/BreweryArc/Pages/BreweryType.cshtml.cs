using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BreweryType.Pages
{
    public class BreweriesType : PageModel
    {
        public SelectList BreweryList { get; set; }
        public string Type { get; set; }
        public List<string> Count_list { get; set; }
        public void OnGetAsync(string query)
        {

            InitStateDropdown();
            using (var webClient = new WebClient())

            {

                string jsonString = webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                
                var Brewery_Type = Breweries.BreweryCollection.FromJson(jsonString);
          

                if (!string.IsNullOrWhiteSpace(query))
                {
                    var Brewery_detailsList = Brewery_Type.ToList();
                   
                    var typeWiseBrewerydetails = Brewery_detailsList.FindAll(x => string.Equals(x.BrewerySelect.ToString(), query, StringComparison.OrdinalIgnoreCase));
                    
                    
                    if (typeWiseBrewerydetails != null && typeWiseBrewerydetails.Count > 0)
                    {
                   ViewData["Brewery_Type"] = typeWiseBrewerydetails;                     
                    }
                    else
                    {
                        ViewData["Brewery_Type"] = null;
                    }
                }
                else
                {
                    ViewData["Brewery_Type"] = null;
                }

                Type = query;

            }
        }

            private void InitStateDropdown()
            {
            var Count_list = new List<string>
            {
                { "Micro" },
                { "Large" },               

            };


                ViewData["Type"] = new SelectList(Count_list);
            }
        }
    }
