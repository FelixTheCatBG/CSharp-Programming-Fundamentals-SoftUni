using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = string.Empty;
            while (input != "Worm Ipsum")
            {
                var inputLine = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputLine.Count > 1)
                {
                    input = Console.ReadLine();
                    continue;
                }


                var splitWords = input.Trim(new[] { '.', '?', ' ', '?' }).Split(' ').ToList();
                for (int i = 0; i < splitWords.Count; i++)
                {
                    if (!splitWords[i]
                      .ToCharArray()
                      .GroupBy(c => c)
                      .Where(g => g.Count() > 1).Any())
                    {
                        continue;
                    }

                    char[] chars = splitWords[i].ToCharArray();
                    Dictionary<char, int> dictionary = new Dictionary<char, int>();

                    foreach (char c in chars)
                    {
                        if (Char.IsDigit(c))
                        { continue; 
                        }
                        if (!dictionary.ContainsKey(c))
                        {
                            dictionary[c] = 1;
                        }
                        else
                        {
                            dictionary[c]++;
                        }
                    }

                   var resultDictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    var charToReplace = resultDictionary.Keys.First();
                    splitWords[i] = new String(charToReplace, splitWords[i].Length);

                    for (int j = 0; j < splitWords.Count; j++)
                    {
                        if (splitWords[j] != "," || splitWords[i] != "'")
                        {
                            splitWords[] = charToReplace.ToString();
                        }
                        else
                        {
                            continue;
                        }
                    }


                }

                if (splitWords[0][0] != splitWords[0][1])
                {
                    splitWords[0] = splitWords[0].Remove(1).ToUpper() + splitWords[0].Substring(1);

                }



                result = (string.Join(" ", splitWords) + ".");

                Console.WriteLine(result);


                input = Console.ReadLine();
            }
        }
    }
}
