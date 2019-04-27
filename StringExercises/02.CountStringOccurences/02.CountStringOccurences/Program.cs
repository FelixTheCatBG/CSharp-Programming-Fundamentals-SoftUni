using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountStringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var word = Console.ReadLine().ToLower();
            var count = 0;
            var index = text.IndexOf(word);
            while (index != -1)
            {
                count++;
                 index = text.IndexOf(word,index + 1);
                 
            }


            Console.WriteLine(count);
        }
    }
}
