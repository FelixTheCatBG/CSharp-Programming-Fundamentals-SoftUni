using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElementsOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToList();

            var results = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                if (i % 2 != 0)
                {
                    results.Add(currentWord);
                }
            }

            Console.WriteLine(string.Join("", results));
        }
    }
}
