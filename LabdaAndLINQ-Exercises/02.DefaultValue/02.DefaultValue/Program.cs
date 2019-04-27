using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, string>();

            while (input != "end")
            {
                var inputString = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(inputString[0]))
                {
                    dict[inputString[0]] = inputString[1];
                }

                dict[inputString[0]] = inputString[1];

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

         
            var dictDiff = dict.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, x => x.Value);
            var dictEq = new Dictionary<string, string>();

            foreach (var kvp in dict)
            {

                if (kvp.Value == "null")
                {
                    dictEq[kvp.Key] = input;
                }
                
            }

          
            foreach (var kvp in dictDiff)
            {
                Console.WriteLine("{0} <-> {1}",kvp.Key,kvp.Value);
            }
            foreach (var kvp in dictEq)
            {
                Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
