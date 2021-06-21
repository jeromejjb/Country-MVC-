using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryListView
    {
        public List<Country> Country { get; set; }

        public CountryListView(List<Country> Countrys)
        {
            this.Country = Countrys;
        }

        public Country Display()
        {
            Console.WriteLine("Here are a list of Countries");
            for (int i = 0; i < Country.Count; i++)
            {
                Country c = Country[i];
                Console.WriteLine($"{i +1}: {c.Name}");
            }
            Console.WriteLine("Please select a country to learn more about by index");
            int input = int.Parse(Console.ReadLine());
            Country output = Country[input -1];

            return output;
        }
    }
}
