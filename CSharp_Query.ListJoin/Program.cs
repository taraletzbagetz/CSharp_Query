using CSharp_Query.DAO;
using CSharp_Query.Entity;

namespace CSharp_Query.ListJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = new List<CatalogueCountryRestriction>();
            var listInput = CountryDAO.MockDataAllCountry();
            var allCountries = CountryDAO.GetAllCountries();

            for (int i = 0; i < 15000; i++)
            {
                var qry = listInput.GroupJoin(
                  allCountries,
                  x => x,
                  y => y.Code,
                  (a, b) => new Country(b.SingleOrDefault() == null ? "" : b.SingleOrDefault().Name, a, b.SingleOrDefault() == null ? "" : b.SingleOrDefault().Code)).ToList<Country>();

                output.Add(new CatalogueCountryRestriction { CatalogueId = i.ToString(), CountryRestrinctions = qry });
            }
        }
    }
}
