using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            numbers.Sort();
            int counter = 1;
            numbers.Add(int.MaxValue);
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var currentNumber = numbers[i];
                var nextNumber = numbers[i + 1];
                if (currentNumber == nextNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}" , currentNumber, counter);
                    counter = 1;
                }
               
            }
        }
    }
}
