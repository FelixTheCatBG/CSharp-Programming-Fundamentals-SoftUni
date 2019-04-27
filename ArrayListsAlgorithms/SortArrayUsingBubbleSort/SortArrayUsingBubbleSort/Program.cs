using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool swapped = false;
            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var leftElement = numbers[i];
                    var rightElement = numbers[i + 1];
                    if (leftElement > rightElement)
                    {
                        numbers[i] = rightElement;
                        numbers[i + 1] = leftElement;
                        swapped = true;
                    }

                }

            } while (swapped);

            Console.WriteLine(string.Join(" ",numbers));
        }

        
    }
}
