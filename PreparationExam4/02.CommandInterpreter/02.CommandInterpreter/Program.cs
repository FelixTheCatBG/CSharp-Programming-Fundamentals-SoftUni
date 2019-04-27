using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine()
                .Split(' ')
                .ToList();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var inputLine = input.Split(' ').ToArray();

                switch (inputLine[0])
                {
                    case "reverse":
                        var start = int.Parse(inputLine[2]);
                        var count = int.Parse(inputLine[4]);
                        if (isValid(stringArray,start,count))
                        {
                            stringArray.Reverse(start, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        //Console.WriteLine(string.Join(" ",stringArrayRev));
                       
                        break;
                    case "sort":
                         var startSort = int.Parse(inputLine[2]);
                        var countSort = int.Parse(inputLine[4]);
                        var stringArrayRevSort = stringArray.Skip(startSort).Take(countSort).ToArray();

                        if (isValid(stringArray,startSort,countSort))
                        {
                            stringArray.Sort(startSort, countSort, null);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        
                        //Console.WriteLine(string.Join(" ", stringArray));
                        break;
                    case "rollLeft":
                        if (int.Parse(inputLine[1]) >= 0)
                        {
                            int rotation = int.Parse(inputLine[1]) % stringArray.Count;
                            for (int j = 0; j < rotation ; j++)
                            {
                                var firstElement = stringArray[0];
                                for (int i = 0; i < stringArray.Count - 1; i++)
                                {
                                    stringArray[i] = stringArray[i + 1];
                                }
                                stringArray[stringArray.Count - 1] = firstElement;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                      
                        //Console.WriteLine(string.Join(" ", newArrayLeft));
                        break;
                    case "rollRight":
                        if (int.Parse(inputLine[1]) >= 0)
                        {
                            int rotation = int.Parse(inputLine[1]) % stringArray.Count;
                            for (int j = 0; j < rotation; j++)
                            {
                                var lastElement = stringArray[stringArray.Count - 1];

                                for (int i = stringArray.Count - 1; i > 0; i--)
                                {
                                    stringArray[i] = stringArray[i - 1];
                                }
                                stringArray[0] = lastElement;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                         
                        
                        break;
                    
                }
                
                input = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", stringArray));
            Console.WriteLine("]");
            
            
        }

        private static bool isValid(List<string> stringArray, int start, int count)
        {
            bool result = start >= 0 && start < stringArray.Count && count >= 0 && (start+count) <= stringArray.Count;
            return result;
        }
    }
}
