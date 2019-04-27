using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbersArray = new int[n];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            var counter = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                var currentNumber = numbersArray[i];
                if (currentNumber < 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
