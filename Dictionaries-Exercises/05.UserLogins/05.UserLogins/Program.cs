using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var userAcc = new Dictionary<string, string>();

            var input = Console.ReadLine();
            var counter = 0;

            while (input != "login")
            {
                var stringInput = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = stringInput[0];
                var password = stringInput[1];

                if (!userAcc.ContainsKey(name))
                {
                    userAcc.Add(name, password);

                }
                else
                {
                    userAcc[name] = password;
                }

                input = Console.ReadLine();
            }

            if (input == "login")
            {
                input = Console.ReadLine();
                do
                {

                    
                    var stringInput = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var name = stringInput[0];
                    var password = stringInput[1];

                    if (!userAcc.ContainsKey(name) || userAcc[name] != password)
                    {
                        counter++;
                        Console.WriteLine("{0}: login failed",name);
                    }
                    else
                    {
                        Console.WriteLine("{0}: logged in successfully",name);
                    }
                    input = Console.ReadLine();

                } while (input != "end");
            }

            Console.WriteLine("unsuccessful login attempts: {0}",counter);
        }
    }
}
