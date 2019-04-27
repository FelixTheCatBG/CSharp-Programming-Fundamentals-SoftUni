using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var personData = new Dictionary<string, List<int>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
               var inputList = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var firstValue = -1;

                if (int.TryParse(inputList[1],out firstValue))
                {
                    AddNumbersToPerson(personData, inputList);
                }

                else
                {
                    CopyNumbersFromOnePersonToAnother(personData, inputList);
                }

                input = Console.ReadLine();
            }

            foreach (var nameAndNumbers in personData)
            {
                Console.WriteLine("{0} === {1}", nameAndNumbers.Key, string.Join(", ", nameAndNumbers.Value));
            }
        }

        private static void CopyNumbersFromOnePersonToAnother(Dictionary<string, List<int>> personData, string[] inputList)
        {
            if (personData.ContainsKey(inputList[1]))
            {
                personData[inputList[0]] = new List<int>();
                foreach (var number in personData[inputList[1]])
                {

                    personData[inputList[0]].Add(number);

                }
            }
        }

        private static void AddNumbersToPerson(Dictionary<string, List<int>> personData, string[] inputList)
        {
            if (!personData.ContainsKey(inputList[0]))
            {
                personData[inputList[0]] = new List<int>();
            }

            for (int i = 1; i < inputList.Length; i++)
            {
                personData[inputList[0]].Add(int.Parse(inputList[i]));
            }
        }
    }
}
