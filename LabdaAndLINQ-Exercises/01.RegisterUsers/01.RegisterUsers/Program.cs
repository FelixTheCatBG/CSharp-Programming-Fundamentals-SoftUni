using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.RegisterUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regList = new Dictionary<string,DateTime>();

            while (input != "end")
            {
                var inputString = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!regList.ContainsKey(inputString[0]))
                {
                    regList[inputString[0]] = DateTime.ParseExact(inputString[1], "dd/MM/yyyy", null);
                }

                input = Console.ReadLine();
            }

            regList = regList.Reverse().OrderBy(x => x.Value).Take(5).ToDictionary(x => x.Key, x => x.Value);
            var result = regList.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            //int counter = 0;
            foreach (var kvp in result)
            {
                
                    Console.WriteLine("{0}", kvp.Key);
                    
                
               
            }

        }
    }
}
