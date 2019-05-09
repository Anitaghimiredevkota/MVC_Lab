using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryListView:IView
    {
        private List<Country> countries;
        public List<Country> Countries
        {
            set { countries = value; }
            get { return countries; }
        }
        public CountryListView(List<Country> _counteirs)
        {
            countries = _counteirs;
        }

        public CountryListView()
        {
        }

        public void Display()
        {

            //List<Country> countries = new List<Country>();
            int count = 0;
            foreach (Country country in countries)
            {
                Console.WriteLine($"{count} { country.Name}");
                count++;
            }
        }
    }
}
