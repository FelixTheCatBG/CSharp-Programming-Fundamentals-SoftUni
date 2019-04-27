using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Person
    {
        private string Name;
        private int Age;
        private List<BankAccount> accounts;

        public Person(string Name,int Age) {
            this.Name = Name;
            this.Age = Age;
            this.accounts = new List<BankAccount>();
        }
        public Person(string Name, int Age,List<BankAccount> accounts)
            
        {
            this.Name = Name;
            this.Age = Age;
            this.accounts = accounts;
        }
        public double GetBalance() 
        {
            return this.accounts.Sum(x => x.Balance);
        }
    }

