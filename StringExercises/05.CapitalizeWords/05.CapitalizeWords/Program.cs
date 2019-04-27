using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CapitalizeWords
{
    class Program
    {
        static void Main(string[] args){
        //{char.ToUpper(str[0]) + str.Substring(1);
            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputString = input.ToLower().Split(new[] {' ','!','.'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                var result = new List<string>();
                for (int i = 0; i < inputString.Length; i++)
                {
                                      
                    if (inputString[i]!= "")
                    {
                        
                        inputString[i] = char.ToUpper(inputString[i][0]) + inputString[i].Substring(1);
                        char[] a = inputString[i].ToCharArray();
                        a[0] = char.ToUpper(a[0]);
                        var resultWord = new string(a);
                        result.Add(resultWord);
                    }
                    

                }

                Console.WriteLine(string.Join(", ",result));

                input = Console.ReadLine();
            }
            


        }
    }
}
