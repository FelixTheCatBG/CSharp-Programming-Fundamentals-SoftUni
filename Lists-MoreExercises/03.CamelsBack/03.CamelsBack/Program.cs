using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var camelSize = int.Parse(Console.ReadLine());
            var counter = 0;
            
            
                while (numbers.Count != camelSize)
                {
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(numbers.Count - 1);
                    counter++;
                }

                if (counter == 0) 
                {
                    Console.WriteLine("already stable: {0}", string.Join(" ", numbers));
                }
                if (counter > 0)
                {

                    Console.WriteLine("{0} rounds", counter);
                    Console.WriteLine("remaining: {0}", string.Join(" ", numbers));
                }
                          
        }
    }
}
