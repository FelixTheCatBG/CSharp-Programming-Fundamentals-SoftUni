using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbersWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(numbers);

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
                if (stack.Count > 0)
                {
                    Console.Write(' ');
                }

            }

        }
    }
}
