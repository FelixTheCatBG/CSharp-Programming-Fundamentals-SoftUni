using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GroupContinentsCountriesCities
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var townsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var inputString = input.Split(' ').ToArray();
                var continent = inputString[0];
                var country = inputString[1];
                var town = inputString[2];

                AddTown(townsData, continent, country, town);

                
            }

            foreach (var Continent in townsData)
            {
                var continentName = Continent.Key;
                var countriesNames = Continent.Value;

                PrintTowns(continentName, countriesNames);
            }
        }

        private static void PrintTowns(string continentName, SortedDictionary<string, SortedSet<string>> countriesNames)
        {
            Console.WriteLine("{0}:", continentName);

            foreach (var countries in countriesNames)
            {
                var countryName = countries.Key;
                var townName = countries.Value;

                Console.WriteLine("{0} -> {1}", countryName, string.Join(", ", townName));
            }
        }

        private static void AddTown(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> townsData, string continent, string country, string town)
        {
            if (!townsData.ContainsKey(continent))
            {
                townsData[continent] = new SortedDictionary<string, SortedSet<string>>();
            }

            if (!townsData[continent].ContainsKey(country))
            {
                townsData[continent][country] = new SortedSet<string>();
            }

            townsData[continent][country].Add(town);
        }

       
        
    }
}
