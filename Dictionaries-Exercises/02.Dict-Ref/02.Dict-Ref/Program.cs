using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var wordDic = new Dictionary<string, int>();
            var inputString = new List<string>();
            var inputLine = Console.ReadLine();
            var value = -1;

            while (inputLine != "end")
            {
                inputString = inputLine.Split(new[] {' ','='},StringSplitOptions.RemoveEmptyEntries).ToList();
                if (int.TryParse(inputString[1], out value))
                {

                    if (wordDic.ContainsKey(inputString[0]))
                    {
                        wordDic[inputString[0]] = value;
                    }
                    else
                    {
                        wordDic.Add(inputString[0], value);
                    }
                }
                else {

                    if (wordDic.ContainsKey(inputString[1]))
                    {
                        wordDic[inputString[0]] = wordDic[inputString[1]];
                    }
                
                }
                 inputLine = Console.ReadLine();
            }

            foreach (var kvp in wordDic)
            {
                Console.WriteLine("{0} === {1}",kvp.Key,kvp.Value);
            }
        }
    }
}
