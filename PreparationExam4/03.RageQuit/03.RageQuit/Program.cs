using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(\D+?)([0-9]+)";
            var regex = new Regex(pattern);
            string inputLine = Console.ReadLine();

            var matches = regex.Matches(inputLine);

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
               var matchDig = match.Groups[1].Value;
               var matchX = int.Parse(match.Groups[2].Value);

               for (int i = 0; i < matchX; i++)
               {
                   result.Append(matchDig.ToUpper());
               }
            }
            var finalResult = result.ToString();
            int count = finalResult.Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}",count);
            Console.WriteLine(finalResult);
        }
    }
}
