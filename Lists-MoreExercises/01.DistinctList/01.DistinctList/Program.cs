using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var counter = 1;

            foreach (var item in numbers)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (item == numbers[i])
                    {
                        counter++;
                        numbers.Remove(numbers[i]);
                    }
                }

                if (counter > 1)
                {
                    
                }
            }
        }
    }
}
