using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ');

            var foundWords = new List<string>();
            var countWords = new List<int>();
           
           for (int i = 0; i < words.Length; i++)
           {
               var currentWord = words[i];

               if (foundWords.Contains(currentWord))
               {
                   int wordIndex = foundWords.IndexOf(currentWord);
                   countWords[wordIndex]++;
               }
               else {
                   foundWords.Add(currentWord);
                   countWords.Add(1);
               }
           }

           
           bool swapped = false;

           do{
                swapped = false;
           for (int i = 0; i < countWords.Count - 1; i++)
           {
               var currentCount = countWords[i];
               var currentFoundWord = foundWords[i];

               if (countWords[i] < countWords[i + 1])
               {
                   countWords[i] = countWords[i + 1];
                   foundWords[i] = foundWords[i + 1];
                   countWords[i + 1] = currentCount;
                   foundWords[i + 1] = currentFoundWord;
                   swapped = true;
               }
           }
           } while (swapped);

           decimal sum = 100 / (decimal)countWords.Sum();
           decimal percentage;


           for (int i = 0; i < foundWords.Count; i++)
           {
               percentage = sum * countWords[i];
               Console.WriteLine("{0} -> {1} times ({2:f2}%)",foundWords[i],countWords[i], percentage);
           }
        }
    }
}
