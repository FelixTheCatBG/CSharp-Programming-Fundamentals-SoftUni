using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankData = new Dictionary<string, Dictionary<string, decimal>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputString = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!bankData.ContainsKey(inputString[0]))
                {
                    bankData[inputString[0]] = new Dictionary<string, decimal>();
                }
                if (!bankData[inputString[0]].ContainsKey(inputString[1]))
                {
                    bankData[inputString[0]].Add(inputString[1], 0);
                }
                bankData[inputString[0]][inputString[1]] += decimal.Parse(inputString[2]);

                input = Console.ReadLine();
            }

            bankData 
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                     .OrderByDescending(account => account.Value)
                     .ToList()
                     .ForEach(account => Console.WriteLine("{0} -> {1} ({2})",account.Key,account.Value,bank.Key)));


        }
    }
}
