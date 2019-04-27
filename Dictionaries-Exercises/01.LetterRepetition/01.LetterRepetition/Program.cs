using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var wordCount = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if (wordCount.ContainsKey(letter))
                {
                    wordCount[letter]++;
                }
                else { 
                wordCount[letter] = 1;
                }
            }

            foreach (var kvp in wordCount)
            {
                Console.WriteLine("{0} -> {1}",kvp.Key,kvp.Value);
            }
            
        }
    }
}
