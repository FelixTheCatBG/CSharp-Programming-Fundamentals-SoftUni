using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] {' '})
                .ToList();

            var result = new List<string>();

            var chars = string.Join(string.Empty, words).ToCharArray();
            int sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                
                sum += chars[i];
            }

           var delimiter =Char.ToUpper((char)(sum / chars.Length));
           var delimiterString = delimiter.ToString();

           for (int i = 0; i < words.Count; i++)
           {
                result.Add(words[i]);
                result.Add(delimiterString);
          }

           result.RemoveAt(result.Count - 1);

           Console.WriteLine(string.Join(string.Empty,result));
        }
    }
}
