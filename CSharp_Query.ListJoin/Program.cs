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
                  foo => foo,
                  bar => bar.Code,
                  (f, bs) => new Country(bs.SingleOrDefault() == null ? "" : bs.SingleOrDefault().Name, f, bs.SingleOrDefault() == null ? "" : bs.SingleOrDefault().Code)).ToList();

                output.Add(new CatalogueCountryRestriction { CatalogueId = i.ToString(), CountryRestrinctions = qry });
            }
        }
    }
}
