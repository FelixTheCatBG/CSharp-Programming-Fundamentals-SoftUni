using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

           var result = numbers
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

           Console.WriteLine(string.Join(" ",result));
        }
    }
}
