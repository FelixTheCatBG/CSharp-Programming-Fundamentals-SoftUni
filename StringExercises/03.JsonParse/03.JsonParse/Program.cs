using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Array;
namespace _03.JsonParse
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var Students = new List<Student>();
            
            var inputLine = Console.ReadLine().Split(new string[] {"},{"},StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < inputLine.Length; i++)
            {
                inputLine[i] = inputLine[i].Replace('"',' ').Replace('[',' ').Replace(']',' ').Replace('{',' ').Replace('}',' ').Trim();
            }

            foreach (var item in inputLine)
            {
                var stringLine = item.Split(new[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                

                var stName = stringLine[1];
                var stAge = stringLine[3];
                var stGrade = stringLine.Skip(5).Select(int.Parse).ToArray();

                var newStudent = new Student();
                newStudent.Name = stName;
                newStudent.Age = int.Parse(stAge);
                newStudent.Grades = stGrade;
                Students.Add(newStudent);

            }

            foreach (var student in Students)
            {
                if (student.Grades.Length == 0)
                {
                    Console.WriteLine("{0} : {1} -> None",student.Name,student.Age);
                }
                else
                {
                    Console.WriteLine("{0} : {1} -> {2}", student.Name, student.Age, string.Join(", ", student.Grades));
                }
            }
            //for (int i = 0; i < inputLine.Length; i++)
            //{
            //    Console.WriteLine(inputLine[i]);
            //}
        }
    }
}
