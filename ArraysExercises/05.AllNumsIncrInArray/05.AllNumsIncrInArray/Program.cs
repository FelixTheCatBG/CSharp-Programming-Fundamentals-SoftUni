using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AllNumsIncrInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areAllEqual = true;
            int previous = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= previous)
                {
                    areAllEqual = false;
                    break;
                }
                previous = numbers[i];
            }

            if (areAllEqual)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
