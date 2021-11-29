using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreweryArc
{
    public class BeerList
    {

        static BeerList()
        {
            allBeers = new List<Beers>();
        }

        public static IList<Beers> allBeers { get; set; }
    }
}
