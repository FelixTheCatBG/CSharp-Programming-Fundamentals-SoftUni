using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhoneBook
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
            var inputLine = Console.ReadLine();
            while (inputLine != "done") 
            {
                PrintElements(numbers, names, inputLine);
                inputLine = Console.ReadLine();
            }
        }

        private static void PrintElements(string[] numbers, string[] names, string inputLine)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == inputLine)
                {
                    Console.WriteLine("{0} -> {1}", names[i],numbers[i]);
                }
            }
        }
    }
}
