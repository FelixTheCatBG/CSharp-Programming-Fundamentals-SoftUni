using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountOfCappitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                string currentWord = strings[i];
                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];
                    if (character >= 65 && character <= 90)
                    {
                        count++;
                    }
                }
                
            }

            Console.WriteLine(count);
        }
    }
}
