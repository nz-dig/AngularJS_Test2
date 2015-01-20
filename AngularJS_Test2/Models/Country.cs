using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJS_Test2.Models
{
    public class Continent
    {
        public Continent()
        {
            Countries = new List<Country>();
        }
        public string Name { get; set; }
        public IList<Country> Countries { get; set; }

    }
    public class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
    }
}