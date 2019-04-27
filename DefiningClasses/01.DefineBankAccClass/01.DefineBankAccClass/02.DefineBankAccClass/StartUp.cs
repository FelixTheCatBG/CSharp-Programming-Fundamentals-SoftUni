using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class StartUp
    {
        public void Main(string[] args)
        {
            var BankAcc = new BankAccount();

            BankAcc.ID = 1;
            BankAcc.Balance = 15;

            Console.WriteLine(BankAcc.ToString());

        }
    }
