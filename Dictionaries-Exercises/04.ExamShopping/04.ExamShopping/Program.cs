using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingItems = new Dictionary<string, int>();
           

            var input = Console.ReadLine();
            
                while (input != "shopping time")
                {

                    var inputString = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    
                        if (shoppingItems.ContainsKey(inputString[1]))
                        {
                            shoppingItems[inputString[1]] += int.Parse(inputString[2]);
                        }
                        else
                        {
                            shoppingItems.Add(inputString[1], int.Parse(inputString[2]));   
                        }
                        input = Console.ReadLine();
                }

                if (input == "shopping time")
                {
                    input = Console.ReadLine();

                    if (input == "exam time")
                    {
                        foreach (var kvp in shoppingItems)
                        {
                            if (kvp.Value > 0)
                            {
                                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                            }

                        }
                    }

                    else
                    {
                        do
                        {

                            var inputString = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                            if (shoppingItems.ContainsKey(inputString[1]) && shoppingItems[inputString[1]] > 0)
                            {
                                shoppingItems[inputString[1]] -= int.Parse(inputString[2]);
                            }
                            else if (shoppingItems.ContainsKey(inputString[1]) && shoppingItems[inputString[1]] < 0)
                            {
                                Console.WriteLine("{0} out of stock", inputString[1]);
                            }
                            else
                            {
                                Console.WriteLine("{0} doesn't exist", inputString[1]);
                            }
                            input = Console.ReadLine();
                        } while (input != "exam time");
                        foreach (var kvp in shoppingItems)
                        {
                            if (kvp.Value > 0)
                            {
                                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                            }

                        }

                    }
                

 
                }
        }
    }
}
