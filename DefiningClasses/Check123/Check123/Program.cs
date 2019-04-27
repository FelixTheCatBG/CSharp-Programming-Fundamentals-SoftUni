using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int,BankAccount>();
            var input = Console.ReadLine();
            var person = new Person("zz", 1);

            while (input != "End")
            {
                var cmndLine = input.Split();

                switch (cmndLine[0])
                {
                    case "Create":
                        Create(cmndLine,accounts);
                        break;
                    case "Deposit":
                        Deposit(cmndLine,accounts);
                        break;
                    case "Withdraw":
                        Withdraw(cmndLine,accounts);
                        break;
                    case "Print":
                        Print(cmndLine,accounts);
                        break;

                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            
        }

        private static void Print(string[] cmndLine, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmndLine[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] cmndLine, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmndLine[1]);
            var amount = double.Parse(cmndLine[2]);
            if (accounts.ContainsKey(id))
            {
                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
                
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] cmndLine, Dictionary<int, BankAccount> accounts)
        {
             var id = int.Parse(cmndLine[1]);
             var amount = double.Parse(cmndLine[2]);
             if (accounts.ContainsKey(id))
             {
                 accounts[id].Deposit(amount);
             }
             else
             {
                 Console.WriteLine("Account does not exist");
             }
        }

        private static void Create(string[] cmndLine, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmndLine[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();                
                acc.ID = id;
                accounts.Add(id,acc);
            }
        }
    }

