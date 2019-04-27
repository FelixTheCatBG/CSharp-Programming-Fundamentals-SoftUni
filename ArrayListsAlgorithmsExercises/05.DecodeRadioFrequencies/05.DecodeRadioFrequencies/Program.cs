using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var result = new string[numbers.Length];

          string[] parts = new string[2];
          char leftPart;
          char rightPart;
           for (int i = 0; i < numbers.Length; i++)
           {
               
               var stringNumber = numbers[i];
               parts = stringNumber.Split('.');
               leftPart = (char)(int.Parse(parts[0]));
               rightPart = (char)(int.Parse(parts[1]));
               if (leftPart != 0)
               {
                   result[i] = leftPart.ToString();
               }
               else {
                   result[i] = string.Empty;
               }
               result[i] = leftPart.ToString();
               result.Insert(numbers.Length - 1 - i, (char)(int.Parse(rightPart)));
               //Console.WriteLine((char)(int.Parse(rightPart)));
           }
           Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
