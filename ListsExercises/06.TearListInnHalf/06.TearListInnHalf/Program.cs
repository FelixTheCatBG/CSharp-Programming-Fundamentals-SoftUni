using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TearListInnHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var firstPart = new List<int>();
            var secondPart = new List<int>();
            var result = new List<int>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                firstPart.Add(numbers[i]);
            }

            for (int i = numbers.Count - 1; i >= numbers.Count/2; i--)
            {
                secondPart.Add(numbers[i]);
            }

            
            secondPart.Reverse();

            for (int i = 0; i < firstPart.Count; i++)
            {
                var firstDigit = secondPart[i] / 10;
                var secondDigit = secondPart[i] % 10;
                result.Add(firstDigit);
                result.Add(firstPart[i]);
                result.Add(secondDigit);
                
            }


            Console.WriteLine(string.Join(" ",result));
           /// Console.WriteLine(string.Join(" ", secondPart));
        }
    }
}
