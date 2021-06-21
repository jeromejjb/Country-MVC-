using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCCountries
{
    class CountryController
    {

        public List<Country> CountryDb { get; set; } = new List<Country>();

    public  CountryController()
        {
            CountryDb.Add(new Country() { Name = "Italy", Continent = "Europe", Colors = new List<string>() { "Red", "Green", "White" } });
            CountryDb.Add(new Country() { Name = "Mexico", Continent = "North America", Colors = new List<string>() { "Red", "Green", "White" } });
            CountryDb.Add(new Country() { Name = "Singapore", Continent = "Asia", Colors = new List<string>() { "Red", "White" } });
            CountryDb.Add(new Country() { Name = "Thaiand", Continent = "Asia", Colors = new List<string>() { "Red", "White", "Blue" } });
            CountryDb.Add(new Country() { Name = "Japan", Continent = "East Asia", Colors = new List<string>() { "Red", "White" } });
            CountryDb.Add(new Country() { Name = "Germany", Continent = "Europe", Colors = new List<string>() { "Red", "Black","Gold" } });
        }
        public void WelcomeAction()
        {
            string userInput = "y";
            while (userInput == "y")
            {
                CountryListView clv = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                Country c = clv.Display();

             CountryAction(c);
             Console.WriteLine("Would you like to see another country? (y/n)");
             userInput = Console.ReadLine().ToLower();
            }
           
        }
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
    }
}
