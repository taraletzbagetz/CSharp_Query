using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Query.Entity
{
    public class CatalogueCountryRestriction
    {
        public String? CatalogueId { get; set; }

        public List<Country>? CountryRestrinctions { get; set; }
    }
}
