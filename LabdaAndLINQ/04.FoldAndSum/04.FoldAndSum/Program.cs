using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = arr.Length / 4;

            var firstRow = arr.Take(k).Reverse();
            var secondRow = arr.Reverse().Take(k);
            var row1 = firstRow.Concat(secondRow).ToArray();
            var row2 = arr.Skip(k).Take(arr.Length / 2).ToArray();
            var result = row1.Select((x, index) => x + row2[index]).ToArray();

            Console.WriteLine(string.Join(" ",result));

        }
    }
}
