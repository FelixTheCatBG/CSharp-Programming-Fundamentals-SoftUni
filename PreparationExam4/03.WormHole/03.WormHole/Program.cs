using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WormHole
{
    class Program
    {
        static void Main(string[] args)
        {
            var wormHoles = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var counter = 0;
            for (int i = 0; i < wormHoles.Count; i++)
            {
                counter++;
                if (wormHoles[i] != 0)
                {
                    var temp = wormHoles[i];
                    wormHoles[i] = 0;
                        i = temp;
                }
            }
            Console.WriteLine("{0}",counter);
        }
    }
}
