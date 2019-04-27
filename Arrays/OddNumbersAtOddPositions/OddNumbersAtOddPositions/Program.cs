using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var currentNumber = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];

                if (currentNumber % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}", i, currentNumber);
                }
            }

        }
    }
}
