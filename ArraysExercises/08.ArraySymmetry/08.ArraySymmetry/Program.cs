using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split(' ')
                .ToArray();

            bool isSymm = true;
            

            for (int i = 0; i < strings.Length/2; i++)
            {
                string firstWord = strings[i];
                string secondWord = strings[strings.Length - 1 - i];
                if (firstWord != secondWord)
                {
                    isSymm = false;
                    break;
                }
                
            }

            if (isSymm)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }
        }
    }
}
