using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine()
                .Split('|')
                .ToList();
            items.Reverse();

            var result = new List<string>();

            foreach (var item in items)
            {
                var nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != " ")
                    {
                        result.Add(num);
                    }
                }

            }

            Console.WriteLine(string.Join(" ", result));


        }
    }
}
