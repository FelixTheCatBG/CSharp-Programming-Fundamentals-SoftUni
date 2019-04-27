using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputLine = input.Split(' ').ToArray();
                switch (inputLine[0])
                {
                    case "exchange":
                        if (int.Parse(inputLine[1]) < 0 || int.Parse(inputLine[1]) >= listOfNumbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        
                        else 
                        {
                            var temp = listOfNumbers.Take(int.Parse(inputLine[1]) + 1).ToList();
                            var temp2 = listOfNumbers.Skip(int.Parse(inputLine[1]) + 1).ToList();
                            listOfNumbers = temp2.Concat(temp).ToList();
                        }
                        
                                          
                    break;

                       case "max":
                    if (inputLine[1] == "even")
                    {
                        if (listOfNumbers.Any(x => x % 2 == 0))
                        {
                            var number = listOfNumbers.OrderByDescending(x => x).Where(x => x % 2 == 0).ToList().First();
                            var indexOfNumber = listOfNumbers.LastIndexOf(number);
                            Console.WriteLine(indexOfNumber);
                        }
                        else
                        {
                            Console.WriteLine("No matches");

                        }
                        
                    }
                    else
                    {
                        if (listOfNumbers.Any(x => x % 2 != 0))
                        {
                            var number = listOfNumbers.OrderByDescending(x => x).Where(x => x % 2 != 0).ToList().First();
                            var indexOfNumber = listOfNumbers.LastIndexOf(number);
                            Console.WriteLine(indexOfNumber);
                        }
                        else
                        {
                            Console.WriteLine("No matches");

                        }
                    }
                    break;
                       case "min":
                    if (inputLine[1] == "even")
                    {
                        
                        if (listOfNumbers.Any(x => x % 2 == 0))
                        {
                           var number = listOfNumbers.OrderBy(x => x).Where(x => x % 2 == 0).ToList().First();
                            var indexOfNumber = listOfNumbers.LastIndexOf(number);
                            Console.WriteLine(indexOfNumber);
                        }
                         
                        else
                        {
                           Console.WriteLine("No matches");
                           
                        }
                        

                    }
                    else
                    {
                        
                        if (listOfNumbers.Any(x => x % 2 != 0)) {
                           var  number = listOfNumbers.OrderBy(x => x).Where(x => x % 2 != 0).ToList().First();
                            var indexOfNumber = listOfNumbers.LastIndexOf(number);
                            Console.WriteLine(indexOfNumber);
                        }
                         
                        else 
                         {
                             Console.WriteLine("No matches");
                         
                         }
                        
                    }

                    break;
                     case "first":
                    if (int.Parse(inputLine[1]) > listOfNumbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }

                    else if (inputLine[2] == "even")
                    {
                        var numbers = listOfNumbers.Where(x => x % 2 == 0).Take(int.Parse(inputLine[1])).ToList();
                        if (numbers.Any())
                        {
                            Console.Write("[");
                            Console.Write(string.Join(", ", numbers));
                            Console.WriteLine("]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else if (inputLine[2] == "odd")
                    {
                        var numbers = listOfNumbers.Where(x => x % 2 != 0).Take(int.Parse(inputLine[1])).ToList();
                        if (numbers.Any())
                        {
                            Console.Write("[");
                            Console.Write(string.Join(", ", numbers));
                            Console.WriteLine("]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }

                    }
                        
                        
                    break;
                     case "last":
                     if (int.Parse(inputLine[1]) > listOfNumbers.Count)
            {
                Console.WriteLine("Invalid count");
                break;
            }
            else if (inputLine[2] == "even")
            {
                var numbers = listOfNumbers.Where(x => x % 2 == 0).Reverse().Take(int.Parse(inputLine[1])).Reverse().ToList();
                if (numbers.Any())
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", numbers));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else if (inputLine[2] == "odd")
            {
                var numbers = listOfNumbers.Where(x => x % 2 != 0).Reverse().Take(int.Parse(inputLine[1])).Reverse().ToList();
                if (numbers.Any())
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", numbers));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine("[]");
                }

            }


                    break;


                         

                }
                input = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ",listOfNumbers));
            Console.Write("]");
        }

        
    }
}
