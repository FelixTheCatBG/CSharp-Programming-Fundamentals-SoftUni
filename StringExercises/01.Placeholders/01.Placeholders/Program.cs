using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var sentAndPlace = input.Split(new[] { '-', '>' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var sentence = sentAndPlace[0].Trim();
                var placeholders = sentAndPlace[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < placeholders.Length; i++)
                {
                    var objectS = "{"+i+"}";
                    sentence = sentence.Replace(objectS,placeholders[i]);
                }
                Console.WriteLine(sentence);
                input = Console.ReadLine();
            }
        }
    }
}
