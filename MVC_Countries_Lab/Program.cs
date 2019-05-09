using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
           // 
            Country c1 = new Country("UAS", "North Americal",new List<string> { "Red","White","Blue"});
            Country c2 = new Country("UK", "Europe", new List<string> { "Red", "White", "Blue" });
            Country c3 = new Country("Nepal", "Asia",new List<string>{ "Red", "Blue", "White" });
            Country c4 = new Country("Jamica", "Africa", new List<string> { "Black", "Yellow", "Green" });
            Country c5 = new Country("Japan", "Asia",new List<string> { "Red", "White" });
            List<Country> countries = new List<Country> { c1, c2, c3, c4, c5 };

            CountryController countryController = new CountryController(countries);
            countryController.WelcomeAction();
        }
    }
}
