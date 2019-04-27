using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigDict = new Dictionary<string, Dictionary<string, string>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                
                var inputString = input.Split(' ').ToArray();

                if (inputString[0] == "flatten")
                {
                    bigDict[inputString[1]] = bigDict[inputString[1]]
                            .ToDictionary(x => x.Key + x.Value, x => "flattened");

                }
                else
                {
                    if (!bigDict.ContainsKey(inputString[0]))
                    {
                        bigDict[inputString[0]] = new Dictionary<string, string>();
                    }

                    if (!bigDict[inputString[0]].ContainsKey(inputString[1]))
                    {
                        bigDict[inputString[0]][inputString[1]]=(inputString[2]);
                    }

                    bigDict[inputString[0]][inputString[1]]=(inputString[2]);
                }
                

                input = Console.ReadLine();
            }

            var orderedDict = bigDict
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDict)
            {
                Console.WriteLine("{0}", entry.Key);

                var innerDict = entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedValues = entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;
                foreach (var innetItem in innerDict)
                {
                    Console.WriteLine("{0}. {1} - {2}", count, innetItem.Key, innetItem.Value);
                    count++;
                }
                foreach (var innerItem in flattenedValues)
                {
                    Console.WriteLine("{0}. {1}", count, innerItem.Key);
                    count++;
                }

            }
        }
    }
}
