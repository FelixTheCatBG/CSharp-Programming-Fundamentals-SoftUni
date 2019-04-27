using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                                                                   StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            bool isUpper = false;
            bool isLower = false;
            var currentWord = string.Empty;

            for (int i = 0; i < words.Count; i++)
            {
                currentWord = words[i];

                isUpper = CheckIfUpper(currentWord);
                isLower = CheckIfLower(currentWord);

                if (isUpper == true && isLower == false)
                {
                    upperCase.Add(currentWord);
                }
                else if (isUpper == false && isLower == true)
                {
                    lowerCase.Add(currentWord);
                }
                else {
                    mixedCase.Add(currentWord);
                }
            }
            
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
          

        }

        private static bool CheckIfLower(string currentWord)
        {
           
            if (currentWord.All(char.IsLower))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private static bool CheckIfUpper(string currentWord)
        {
            if (currentWord.All(char.IsUpper))
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        
    }
}
