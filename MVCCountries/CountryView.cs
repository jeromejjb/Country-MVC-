using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryView
    {


        public Country Country { get; set; }

        public CountryView(Country Country)
        {
            this.Country = Country;
        }

        public void Display()
        {
            Console.WriteLine($"Country Name:{Country.Name}");
            Console.WriteLine($"Country Continent: {Country.Continent}");
            Console.WriteLine($"Country Colors: ");
            foreach (string Color in Country.Colors)
            {
                Console.WriteLine($"{Color}");
            }
        }
    }
}
