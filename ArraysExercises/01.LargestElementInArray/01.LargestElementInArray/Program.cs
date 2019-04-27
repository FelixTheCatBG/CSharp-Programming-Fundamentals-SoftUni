using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbersArray = new int[n];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            var smallestNumber = int.MinValue;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                var currentNumber = numbersArray[i];
                if (currentNumber > smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
