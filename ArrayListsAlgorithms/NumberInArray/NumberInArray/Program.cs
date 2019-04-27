using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var n = int.Parse(Console.ReadLine());
            bool foundNumber = false;

            foreach (var number in numbers)
            {
                if (number == n)
                {
                    foundNumber = true;
                    break;
                }
                
            }

            if (foundNumber == true)
            {
                Console.WriteLine("yes");
            }
            else {
                Console.WriteLine("no");
            }
        }
    }
}
