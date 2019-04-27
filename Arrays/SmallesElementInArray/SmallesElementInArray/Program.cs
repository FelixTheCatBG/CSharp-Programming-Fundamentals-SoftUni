using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallesElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int MinNumberSoFar = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber < MinNumberSoFar)
                {
                    MinNumberSoFar = currentNumber;
                }
            }

            Console.WriteLine(MinNumberSoFar);
        }
    }
}
