using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, double>();
            double value = -1;




            var input = Console.ReadLine();

            while (input != "Over")
            {
                var inputLine = input.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                

                if (double.TryParse(inputLine[1], out value))
                {
                    phoneBook[inputLine[0]] = value;
                }
                else {

                    phoneBook[inputLine[1]] = double.Parse(inputLine[0]);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in phoneBook)
            {
                Console.WriteLine("{0} -> {1}",kvp.Key,kvp.Value);
            }

        }
    }
}
