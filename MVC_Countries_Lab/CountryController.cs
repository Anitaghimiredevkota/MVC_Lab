using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        private List<Country> countryDb;
        public List<Country> CountryDb
        {
            set { countryDb = value; }
            get { return countryDb; }
        }
        public CountryController(List<Country> _countryDb)
        {
            countryDb = _countryDb;
        }
        public void CountryAction(Country c)
        {
            IView view = new CountryView(c);
            view.Display();
        }
        public void WelcomeAction()
        {
            string success1="y";
            while (success1=="y")
            {
                IView view = new CountryListView(countryDb);
                Console.WriteLine("Hello welcome to the country app. Please select a country from the following list");
                view.Display();
                string choice = Console.ReadLine().ToLower();
                bool success = int.TryParse(choice, out int input);
                if (!success || input < 0)
                {
                    Console.WriteLine("Plesae enter a valid number");
                }
                else
                { 
                    CountryAction(countryDb[input]);
                    Console.WriteLine("Would you like to learn about another country");
                    string choice1 = Console.ReadLine().ToLower();
                    if(choice1=="n")
                    {
                        success1 = "n";
                        Console.WriteLine(); ;
                    }
                  

                }
            }
        }
    }
}
