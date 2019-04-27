using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(new[] {' ',',','!','.','?'},StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            var result = new HashSet<string>();
            foreach (var word in array)
            {
                var sb = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }

                var revWord = sb.ToString();

                if (word.Equals(revWord))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",result.OrderBy(x => x)));
        }
    }
}
