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
        public List<string> CountList { get; set; }
        public void OnGetAsync(string query)
        {

            InitStateDropdown();
            using (var webClient = new WebClient())

            {

                string breweryTypeJson = webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                
                var breweryType = Breweries.BreweryCollection.FromJson(breweryTypeJson);
          

                if (!string.IsNullOrWhiteSpace(query))
                {
                    var breweryDetailsList = breweryType.ToList();
                   
                    var typeWiseBrewerydetails = breweryDetailsList.FindAll(x => string.Equals(x.BrewerySelect.ToString(), query, StringComparison.OrdinalIgnoreCase));
                    
                    
                    if (typeWiseBrewerydetails != null && typeWiseBrewerydetails.Count > 0)
                    {
                   ViewData["BreweryType"] = typeWiseBrewerydetails;                     
                    }
                    else
                    {
                        ViewData["BreweryType"] = null;
                    }
                }
                else
                {
                    ViewData["BreweryType"] = null;
                }

                Type = query;

            }
        }

            private void InitStateDropdown()
            {
            var CountList = new List<string>
            {
                { "Micro" },
                { "Large" },               

            };


                ViewData["Type"] = new SelectList(CountList);
            }
        }
    }
