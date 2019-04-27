using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonClass
{
   public class Person
    {
        public int age;
        public string name;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

            public string Name {
            get { return this.name; }
            set { this.name = value; }

        }

        public Person(string Name, int Age)
        {
            this.Age = age;
            this.Name = name;
            
        }
    }
}
