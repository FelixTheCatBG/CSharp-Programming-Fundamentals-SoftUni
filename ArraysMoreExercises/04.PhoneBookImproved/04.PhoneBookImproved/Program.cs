using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhoneBookImproved
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var names = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var inputLine = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (inputLine[0] != "done")
            {
                if (inputLine[0] == "call")
                {
                PrintElements(numbers,names,inputLine);
               
                
                }
                else if (inputLine[0] == "message")
                {
                
                }
            }
        }

        private static void PrintElements(string[] numbers,  string[] names, string[] inputLine)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == inputLine)
                {
                    Console.WriteLine(numbers[i]);
                }

            }
        }
    }
}
