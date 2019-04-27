using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ');

            var rotated = new string[words.Length];
            rotated[0] = words[words.Length - 1];
            for (int i = 0; i < words.Length - 1; i++)
            {
                rotated[i + 1] = words[i];
            }

            var result = string.Join(" ", rotated);
            Console.WriteLine(result);
        }
    }
}
