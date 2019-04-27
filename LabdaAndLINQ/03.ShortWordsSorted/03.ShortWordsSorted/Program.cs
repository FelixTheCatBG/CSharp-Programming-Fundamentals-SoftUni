using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine();
            var wordsList = new List<string>();

            wordsList = words
                .ToLower()
                .Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ",wordsList));
        }
    }
}
