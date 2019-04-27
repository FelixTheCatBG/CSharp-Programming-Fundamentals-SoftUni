using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int,Dictionary<string,List<string>>>();

            var input = Console.ReadLine();
            while (input != "Time for Code")
            {
                
                var inputLine = input.Split(' ').ToArray();
                var listOfPart = inputLine.Skip(2).ToArray();
                while (true)
                {
                    if (input == "Time for Code")
                    {
                        break;
                    }
                    if (!listOfPart.All(x => x.StartsWith("@")) || !inputLine[1].StartsWith("#"))
                    {
                        break;
                    }

                    //if (dictionary.ContainsKey(int.Parse(inputLine[0])) & !dictionary[int.Parse(inputLine[0])].ContainsKey(inputLine[1]))
                    //{
                    //    break;
                    //}
                    //else { continue; }

                    //if (inputLine.Length < 2)
                    //{ break; }
                    //else { continue; }

                    
                     

                    

                    if (!dictionary.ContainsKey(int.Parse(inputLine[0])))
                    {
                        dictionary[int.Parse(inputLine[0])] = new Dictionary<string, List<string>>();

                    }

                    if (!dictionary[int.Parse(inputLine[0])].ContainsKey(inputLine[1]))
                    {
                        dictionary[int.Parse(inputLine[0])][inputLine[1]] = new List<string>();
                    }

                    for (int i = 0; i < listOfPart.Length; i++)
                    {
                        dictionary[int.Parse(inputLine[0])][inputLine[1]].Add(listOfPart[i]);
                    }
                }
                
           
                input = Console.ReadLine();
            }

            var resultDictionary = new Dictionary<string, List<string>>();

            foreach (var kvp in dictionary)
	        {
                foreach (var item in kvp.Value)
                {
                    resultDictionary[item.Key] = new List<string>();
                    resultDictionary[item.Key] = item.Value;
                }      
	        }

            var finalResult = resultDictionary
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in finalResult)
            {
                Console.WriteLine("{0} - {1}",item.Key,item.Value.Count);

                foreach (var items in item.Value)
                {
                    Console.WriteLine(items);
                }
            }
                
        }
    }
}
