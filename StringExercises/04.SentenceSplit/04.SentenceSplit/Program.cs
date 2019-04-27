using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SentenceSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var delimiter = Console.ReadLine();
            var inputString = input.Split(new string[] { delimiter },StringSplitOptions.None).ToArray();

            Console.WriteLine("[" + string.Join(", ", inputString) + "]");
        }
    }
}
