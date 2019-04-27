using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var personAge = new Dictionary<string, int>();
            var personSalary = new Dictionary<string, double>();
            var personPosition = new Dictionary<string, string>();

            
            var input = Console.ReadLine();

            while (input != "filter base")
            {
               var inputString = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var value = -1;
                double doublevalue = 0.0;

               if (int.TryParse(inputString[1],out value))
               {
                   personAge.Add(inputString[0],value);
               }
               else if (double.TryParse(inputString[1],out doublevalue))
               {
                   personSalary.Add(inputString[0], doublevalue);
               }
               else
               {
                   personPosition.Add(inputString[0], inputString[1]);
               }

               input = Console.ReadLine();
            }

            if (input == "filter base")
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "Position":
                        foreach (var kvp in personPosition)
                        {
                            Console.WriteLine("Name: {0}",kvp.Key);
                            Console.WriteLine("Position: {0}",kvp.Value);
                            Console.WriteLine("====================");
                        }
                        break;

                    case "Age":
                        foreach (var kvp in personAge)
                        {
                            Console.WriteLine("Name: {0}", kvp.Key);
                            Console.WriteLine("Age: {0}", kvp.Value);
                            Console.WriteLine("====================");
                        }

                        break;

                    case "Salary":
                        foreach (var kvp in personSalary)
                        {
                            Console.WriteLine("Name: {0}", kvp.Key);
                            Console.WriteLine("Salary: {0:f2}", kvp.Value);
                            Console.WriteLine("====================");
                        }
                        break;
                }
            }

        }
    }
}
