using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryView:IView
    {
        private Country displayCountry;
        public Country DisplayCountry
        {
            set { displayCountry = value; }
            get { return displayCountry; }
        }

        public CountryView(Country _displayCountry)
        {
            displayCountry = _displayCountry;
        }

        public CountryView()
        {
        }

        public void Display()
        {
            Console.WriteLine($"Name: {displayCountry.Name},Continent : {displayCountry.Continent}  Colors : {string.Join(",", displayCountry.Colors)}");
        }
    }
}
