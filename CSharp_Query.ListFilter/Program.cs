using CSharp_Query.DAO;

namespace CSharp_Query.ListFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allCountries = CountryDAO.GetAllCountries();
            var inputList = CountryDAO.MockDataCountry();

            var filteredData = allCountries.Where(x => inputList.Any(y => y == x.Code)).ToList();
        }
    }
}
