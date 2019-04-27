using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
               var currentNumber = numbers[i];

               if (Math.Sqrt(currentNumber) == (int)Math.Sqrt(currentNumber))
               {
                  result.Add(currentNumber);
               }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
