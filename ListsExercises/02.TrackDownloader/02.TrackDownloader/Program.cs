using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine()
                .Split(' ');

            var input = Console.ReadLine();
            var results = new List<string>();

            while (input != "end")
            {
                var isInBlackList = false;

                foreach (var blackListedWord in blackList)
                {
                    if (input.Contains(blackListedWord))
                    {
                        isInBlackList = true;
                        break;
                    }
                }

                if (!isInBlackList)
                {
                    results.Add(input);
                }

                input = Console.ReadLine();
            }
            results.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, results));
        }
    }
}
