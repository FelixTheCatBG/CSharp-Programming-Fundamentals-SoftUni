using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                for (int i2 = 0; i2 < list.Count; i2++)
                {
                    if (numbers.Contains(list[i2]))
                    {
                        numbers.RemoveAll(x => x == list[i2]);
                    }
                    else 
                    {
                        numbers.Add(list[i2]);
                    }
                }
                
            }
            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
