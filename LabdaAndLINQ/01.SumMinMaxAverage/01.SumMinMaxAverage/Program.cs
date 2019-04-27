using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                var readNumber = int.Parse(Console.ReadLine());
                arrayOfNumbers[i] = readNumber;
            }

            Console.WriteLine("Sum = {0}",arrayOfNumbers.Sum());
            Console.WriteLine("Min = {0}",arrayOfNumbers.Min());
            Console.WriteLine("Max = {0}",arrayOfNumbers.Max());
            Console.WriteLine("Average = {0}",arrayOfNumbers.Average());
        }
    }
}
