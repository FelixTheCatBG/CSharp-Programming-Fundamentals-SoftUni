﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else 
                {
                    result.Add(number, 1);
                }
            }

            foreach (var kvp in result)
            {
                Console.WriteLine("{0} -> {1}",kvp.Key,kvp.Value);
            }
        }
    }
}
