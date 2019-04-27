using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var shellData = new Dictionary<string, HashSet<int>>();
            var input = Console.ReadLine();

            while (input != "Aggregate")
            {
                var inputString = input.Split(' ').ToList();
                var region = inputString[0];
                var size = int.Parse(inputString[1]);

                if (!shellData.ContainsKey(region))
                {
                    shellData[region] = new HashSet<int>();
                }

                shellData[region].Add(size);

                input = Console.ReadLine();
            }

            foreach (var region in shellData)
            {
                var regionName = region.Key;
                var shellSizes = region.Value;
                int avg = ((int)shellSizes.Sum() - (int)shellSizes.Average());
                Console.WriteLine("{0} -> {1} ({2})",regionName,string.Join(", ",shellSizes),avg);
            }
        }
    }
}
