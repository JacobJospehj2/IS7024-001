using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BreweryArc.Pages
{
    public class BeerTalkModel : PageModel

    {
        [BindProperty]
        public Beers beer { get; set; }

    public void OnGet()
    {
        ViewData["BeerList"] = BeerList.allBeers;
    }

    public void OnPost()
    {
        
        string beerinfo = beer.FirstName + beer.LastName + beer.FavouriteBeer + beer.Capacity+beer.Improvement;
        BeerList.allBeers.Add(beer);

        ViewData["BeerList"] = BeerList.allBeers;
    }
}
}

