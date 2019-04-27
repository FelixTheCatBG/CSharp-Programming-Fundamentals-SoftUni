﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areAllEqual = true;
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    areAllEqual = false;
                    break;
                }
            }

            if (areAllEqual)
            {
                Console.WriteLine("Yes");
            }

            else {
                Console.WriteLine("No");
            }

        }
    }
}
