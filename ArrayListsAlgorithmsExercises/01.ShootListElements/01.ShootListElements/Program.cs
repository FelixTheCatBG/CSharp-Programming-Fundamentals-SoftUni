using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            string inputLine = Console.ReadLine();
            int lastRemoved = -1;
            string output = string.Empty;
            while (inputLine != "stop")
            {
                if (inputLine == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        output = "nobody left to shoot! last one was {0}";
                         break;
                    }
                   
                        var sum = numbers.Sum();
                        double average = (double)sum / numbers.Count;
                        lastRemoved = ShootListElements(numbers, average);
                        decrementValues(numbers);
                 }

                else
                {
                    var numberToAdd = int.Parse(inputLine);
                    numbers.Insert(0, numberToAdd);
                }

                inputLine = Console.ReadLine();
            }

            if (numbers.Count > 0 && output == "") 
            {
                Console.Write("survivors: ");
                Console.WriteLine(string.Join(" ",numbers));
            }
            else if (numbers.Count == 0 && output == "") {
                
                Console.WriteLine("you shot them all. last one was {0}",lastRemoved);
            }
            else
            {
                Console.WriteLine(output, lastRemoved);
            }

        }

       public  static int ShootListElements(List<int> numbers, double average)
        {
            int result = -1;

            if (numbers.Count == 1)
            {
                Console.WriteLine("shot {0}", numbers[0]);
                result = numbers[0];
                numbers.RemoveAt(0);
                return result;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < average)
                {
                    Console.WriteLine("shot {0}", numbers[i]);
                    result = numbers[i];
                    numbers.RemoveAt(i);
                    break;
                }
            }
            return result;
        }

        

        private static void decrementValues(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

         
    }

}
