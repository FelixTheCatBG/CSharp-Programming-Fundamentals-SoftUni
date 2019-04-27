using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();
            var result = new List<string>();

            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else {
                    wordsCount.Add(word, 1);
                }
            }

            foreach (var kvp in wordsCount)
            {
                if (kvp.Value % 2 != 0)
                {
                    result.Add(kvp.Key);
                }
                
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
