using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectData = new Dictionary<string, Dictionary<string, string>>();

            var input = Console.ReadLine();
            while (input != "lambada")
            {
                var inputString = input.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputString.Length > 1)
                {
                    var selector = inputString[0];
                    var selectorObject = inputString[1];
                    var property = inputString[2];

                    if (!objectData.ContainsKey(inputString[0]))
                    {
                        objectData[inputString[0]] = new Dictionary<string, string>();
                    }

                    objectData[inputString[0]][inputString[1]] = inputString[2];
                }

                else
                {
                    objectData = objectData
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                            .ToDictionary(selectorObject => selectorObject.Key,
                            selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in objectData)
            {

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine("{0} => {1}.{2}", kvp.Key, item.Key, item.Value);
                }
            }

        }
    }
}
