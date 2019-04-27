using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {

                var firstDigit = inputLine[0];
              
                numbers.Insert(int.Parse(firstDigit.ToString()), int.Parse(inputLine));

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
           
        }
    }
}
