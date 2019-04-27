using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var towns = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var inputString = input.Split(' ').ToList();
                var continent = inputString[0];
                var country = inputString[1];
                var town = inputString[2];

                AddToDictionary(towns, continent, country, town);
            }

            foreach (var continent in towns)
            {
                var continentName = continent.Key;
                var countries = continent.Value;

                PrintOutput(continentName, countries);
            }
        }

        private static void PrintOutput(string continentName, Dictionary<string, List<string>> countries)
        {
            Console.WriteLine("{0}:", continentName);
            foreach (var country in countries)
            {
                var countryName = country.Key;
                var townNames = country.Value;

                Console.WriteLine("   {0} -> {1}", countryName, string.Join(", ", townNames));
            }
        }

        private static void AddToDictionary(Dictionary<string, Dictionary<string, List<string>>> towns, string continent, string country, string town)
        {
            if (!towns.ContainsKey(continent))
            {
                towns[continent] = new Dictionary<string, List<string>>();

            }

            if (!towns[continent].ContainsKey(country))
            {
                towns[continent][country] = new List<string>();
            }

            towns[continent][country].Add(town);
        }
    }
}
