using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LastConsecutive3Str
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int count = 1;
            for (int i = strings.Length - 1; i > 0; i--)
            {
                if (strings[i] == strings[i - 1])
                {
                    count++;

                    if (count == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", strings[i]);
                        break;
                    }

                }
                else {
                    count = 1;
                }
            }
        }
    }
}
