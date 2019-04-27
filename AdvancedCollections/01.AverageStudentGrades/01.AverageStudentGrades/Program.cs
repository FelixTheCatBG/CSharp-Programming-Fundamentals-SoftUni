using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nameAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var inputString = input.Split(' ').ToList();
                var name = inputString[0];
                var grade = double.Parse(inputString[1]);

                if (!nameAndGrades.ContainsKey(name))
                {
                    nameAndGrades[name] = new List<double>();
                }
                     nameAndGrades[name].Add(grade);
            }

            foreach (var name in nameAndGrades)
            {
                var studentName = name.Key;
                var studentGrades = name.Value;
                var average = studentGrades.Average();

                Console.Write("{0} -> ",studentName);

                foreach (var grade in studentGrades)
                {
                    Console.Write("{0:f2} ",grade);
                }
                Console.WriteLine("(avg: {0:f2})",average);
            }
        }
    }
}
