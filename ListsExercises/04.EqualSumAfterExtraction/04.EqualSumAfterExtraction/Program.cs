using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            foreach (var number in firstLine)
            {
                for (int i = 0; i < secondLine.Count; i++)
                {
                    if (number == secondLine[i]) {

                        secondLine.Remove(number);
                    }
                }
            }

            var sumFirstLine = 0;
            var sumSecondLine = 0;

            foreach (var number in firstLine)
            {
                
                sumFirstLine = sumFirstLine + number;
            }
            
            foreach (var number in secondLine)
            {
                
                sumSecondLine = sumSecondLine + number;
            }


            if (sumFirstLine == sumSecondLine)
            {
                Console.WriteLine("Yes. Sum: {0}",sumFirstLine);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}",Math.Abs(sumFirstLine - sumSecondLine));
            }
        }
    }
}
