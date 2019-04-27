using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();
            bool swapped = false;
            do
            {
                swapped = false;

                for (int i = 0; i < words.Length - 1; i++)
                {
                    var temp = words[i];
                    if (words[i].CompareTo(words[i + 1]) > 0)
                    {
                        words[i] = words[i + 1];
                        words[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
