using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04.CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            
            while (input != "Over!")
            {
                var result = string.Empty;
              

                var charsInInput = input.Where(s => !char.IsDigit(s) && s != '+' &&
                s != '-' &&
                s != '*' &&
                s != '/' &&
                s != '.' &&
                s != '!');

                var word = string.Empty;

                var firstPattern = @"^(\d+)[a-zA-Z]+([^a-zA-Z]+)?$";
                var firstReg = new Regex(firstPattern);
                var match = Regex.IsMatch(input, firstPattern);

                if (!match)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var m = int.Parse(Console.ReadLine());

                foreach (var item in charsInInput)
                {
                    word += item;
                }

                if (word.Length != m)
                {
                    input = Console.ReadLine();
                    continue;
                }

                MatchCollection matches = Regex.Matches(input, firstPattern);
                var firstDigits = matches[0].Groups[1].Value;
                var lastDigits = matches[0].Groups[2].Value;

                

                var arrayOfChars = (firstDigits + lastDigits).ToCharArray();
                for (int i = 0; i < arrayOfChars.Length; i++)
                {
                    int current;
                    var parse = int.TryParse(arrayOfChars[i].ToString(), out current);
                    if (parse)
                    {
                        if (current < word.Length && current >= 0)
                        {
                            result += word[current];

                        }
                        else
                        {
                            result += " ";

                        }
                    }

                    
                }
                Console.WriteLine("{0} == {1}", word, result);
                input = Console.ReadLine();
             

               
            }
            
        }
    }
}
