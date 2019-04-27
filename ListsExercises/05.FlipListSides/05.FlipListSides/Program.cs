using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
           
            for (int i = 1; i < (int)numbers.Count/2; i++)
            {
                var currentNumber = numbers[i];

                numbers[i] = numbers[numbers.Count - (i + 1)];
                numbers[numbers.Count - (i + 1)] = currentNumber;
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
