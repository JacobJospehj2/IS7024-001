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

namespace BreweryArc.Pages
{

    public class BreweriesModel : PageModel
    {
        public SelectList CountryList { get; set; }
        public string SearchCountry { get; set; }
        public List<string> Count_list { get; set; }
        public void  OnGetAsync(string query)
        {

            InitStateDropdown();
            using (var webClient = new WebClient())


            {

                string CountryBreweryJson= webClient.DownloadString("https://api.openbrewerydb.org/breweries");
                var BreweryCountryDetails = Breweries.BreweryCollection.FromJson(CountryBreweryJson);


                if (!string.IsNullOrWhiteSpace(query))
                {
                    var BreweryCountryDetailsList = BreweryCountryDetails.ToList();
                    var countryWiseBrewerydetails = BreweryCountryDetailsList.FindAll(x => string.Equals(x.Country.ToString(), query, StringComparison.OrdinalIgnoreCase));
 
                    if (countryWiseBrewerydetails != null && countryWiseBrewerydetails.Count > 0)
                        {
                            ViewData["BreweryCountryDetails"] = countryWiseBrewerydetails;
                        }
                    else
                    {
                        ViewData["BreweryCountryDetails"] = null;
                    }
                }
                else
                {
                    ViewData["BreweryCountryDetails"] = null;
                }

                SearchCountry = query;
            }
        }

        private void InitStateDropdown()
        {
            var Count_list = new List<string>
         {
			{"Afghanistan"},
			{"Albania"},
			{"Algeria"},
			{"American Samoa"},
			{"Andorra"},
			{"Angola"},
			{"Anguilla"},
			{"Antarctica"},
			{"Antigua And Barbuda"},
			{"Argentina"},
			{"Armenia"},
			{"Aruba"},
			{"Australia"},
			{"Austria"},
			{"Azerbaijan"},
			{"Bahamas"},
			{"Bahrain"},
			{"Bangladesh"},
			{"Barbados"},
			{"Belarus"},
			{"Belgium"},
			{"Belize"},
			{"Benin"},
			{"Bermuda"},
			{"Bhutan"},
			{"Bolivia"},
			{"Bosnia And Herzegovina"},
			{"Botswana"},
			{"Bouvet Island"},
			{"Brazil"},
			{"British Indian Ocean Territory"},
			{"Brunei Darussalam"},
			{"Bulgaria"},
			{"Burkina Faso"},
			{"Burundi"},
			{"Cambodia"},
			{"Cameroon"},
			{"Canada"},
			{"Cape Verde"},
			{"Cayman Islands"},
			{"Central African Republic"},
			{"Chad"},
			{"Chile"},
			{"China"},
			{"Christmas Island"},
			{"Cocos (keeling) Islands"},
			{"Colombia"},
			{"Comoros"},
			{"Congo"},
			{"Congo ,Democratic Republic" },
			{"Cook Islands"},
			{"Costa Rica"},
			{"Cote D'ivoire"},
			{"Croatia"},
			{"Cuba"},
			{"Cyprus"},
			{"Czech Republic"},
			{"Denmark"},
			{"Djibouti"},
			{"Dominica"},
			{"Dominican Republic"},
			{"East Timor"},
			{"Ecuador"},
			{"Egypt"},
			{"El Salvador"},
			{"Equatorial Guinea"},
			{"Eritrea"},
			{"Estonia"},
			{"Ethiopia"},
			{"Falkland Islands (malvinas)"},
			{"Faroe Islands"},
			{"Fiji"},
			{"Finland"},
			{"France"},
			{"French Guiana"},
			{"French Polynesia"},
			{"French Southern Territories"},
			{"Gabon"},
			{"Gambia"},
			{"Georgia"},
			{"Germany"},
			{"Ghana"},
			{"Gibraltar"},
			{"Greece"},
			{"Greenland"},
			{"Grenada"},
			{"Guadeloupe"},
			{"Guam"},
			{"Guatemala"},
			{"Guinea"},
			{"Guinea-bissau"},
			{"Guyana"},
			{"Haiti"},
			{"Heard Island And Mcdonald Islands"},
			{"Holy See (vatican City State)"},
			{"Honduras"},
			{"Hong Kong"},
			{"Hungary"},
			{"Iceland"},
			{"India"},
			{"Indonesia"},
			{"Iran, Islamic Republic" },
			{"Iraq"},
			{"Ireland"},
			{"Israel"},
			{"Italy"},
			{"Jamaica"},
			{"Japan"},
			{"Jordan"},
			{"Kazakstan"},
			{"Kenya"},
			{"Kiribati"},
			{"Korea, Democratic People's Republic" },
			{"Korea" },
			{"Kosovo"},
			{"Kuwait"},
			{"Kyrgyzstan"},
			{"Lao People's Democratic Republic"},
			{"Latvia"},
			{"Lebanon"},
			{"Lesotho"},
			{"Liberia"},
			{"Libyan Arab Jamahiriya"},
			{"Liechtenstein"},
			{"Lithuania"},
			{"Luxembourg"},
			{"Macau"},
			{"Macedonia , Former Yugoslav Republic"},
			{"Madagascar"},
			{"Malawi"},
			{"Malaysia"},
			{"Maldives"},
			{"Mali"},
			{"Malta"},
			{"Marshall Islands"},
			{"Martinique"},
			{"Mauritania"},
			{"Mauritius"},
			{"Mayotte"},
			{"Mexico"},
			{"Micronesia, Federated States" },
			{"Moldova, Republic"},
			{"Monaco"},
			{"Mongolia"},
			{"Montserrat"},
			{"Montenegro"},
			{"Morocco"},
			{"Mozambique"},
			{"Myanmar"},
			{"Namibia"},
			{"Nauru"},
			{"Nepal"},
			{"Netherlands"},
			{"Netherlands Antilles"},
			{"New Caledonia"},
			{"New Zealand"},
			{"Nicaragua"},
			{"Niger"},
			{"Nigeria"},
			{"Niue"},
			{"Norfolk Island"},
			{"Northern Mariana Islands"},
			{"Norway"},
			{"Oman"},
			{"Pakistan"},
			{"Palau"},
			{"Palestinian Territory" },
			{"Panama"},
			{"Papua New Guinea"},
			{"Paraguay"},
			{"Peru"},
			{"Philippines"},
			{"Pitcairn"},
			{"Poland"},
			{"Portugal"},
			{"Puerto Rico"},
			{"Qatar"},
			{"Reunion"},
			{"Romania"},
			{"Russian Federation"},
			{"Rwanda"},
			{"Saint Helena"},
			{"Saint Kitts And Nevis"},
			{"Saint Lucia"},
			{"Saint Pierre And Miquelon"},
			{"Saint Vincent And The Grenadines"},
			{"Samoa"},
			{"San Marino"},
			{"Sao Tome And Principe"},
			{"Saudi Arabia"},
			{"Senegal"},
			{"Serbia"},
			{"Seychelles"},
			{"Sierra Leone"},
			{"Singapore"},
			{"Slovakia"},
			{"Slovenia"},
			{"Solomon Islands"},
			{"Somalia"},
			{"South Africa"},
			{"South Georgia And The South Sandwich Islands"},
			{"Spain"},
			{"Sri Lanka"},
			{"Sudan"},
			{"Suriname"},
			{"Svalbard And Jan Mayen"},
			{"Swaziland"},
			{"Sweden"},
			{"Switzerland"},
			{"Syrian Arab Republic"},
			{"Taiwan, Province Of China" },
			{"Tajikistan"},
			{"Tanzania, United Republic" },
			{"Thailand"},
			{"Togo"},
			{"Tokelau"},
			{"Tonga"},
			{"Trinidad And Tobago"},
			{"Tunisia"},
			{"Turkey"},
			{"Turkmenistan"},
			{"Turks And Caicos Islands"},
			{"Tuvalu"},
			{"Uganda"},
			{"Ukraine"},
			{"United Arab Emirates"},
			{"United Kingdom"},
			{"United States"},
			{"United States Minor Outlying Islands"},
			{"Uruguay"},
			{"Uzbekistan"},
			{"Vanuatu"},
			{"Venezuela"},
			{"Viet Nam"},
			{"Virgin Islands , British" },
			{"Virgin Islands, U.S"},
			{"Wallis And Futuna"},
			{"Western Sahara"},
			{"Yemen"},
			{"Zambia"},
			{"Zimbabwe"}
 };


            ViewData["SearchCountry"] = new SelectList(Count_list);
        }
    }
}

