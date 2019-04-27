using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JSONStringfy
{
    class Student
    {
       public string Name { get; set; }
       public int Age { get; set;}
       public int[] Grades { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            var inputLine = Console.ReadLine();
            while (inputLine != "stringify")
            {
                var input = inputLine
                    .Split(new[] { ' ', '!', ',', '.', '>', '-', ':' },StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var stName = input[0];
                var stAge = int.Parse((input[1]));
                var stGrades = input.Skip(2).Select(int.Parse).ToArray();

                var NewStudent = new Student();

                NewStudent.Name = stName;
                NewStudent.Age = stAge;
                NewStudent.Grades = stGrades;

                Students.Add(NewStudent);

                inputLine = Console.ReadLine();
            }

            //Console.WriteLine(
            //    "[" +
            //    string.Join(",",Students.Select(x =>
            //    $"{{name:\"{x.Name}\",age:{x.Age},grades:[{string.Join(", ",x.Grades)}]}}")
            //    )+"]");

            Console.Write("[");
            for (int i = 0; i < Students.Count; i++)
            {

                Console.Write("{name:\"" + Students[i].Name + "\",age:" + Students[i].Age + ",grades:[" + string.Join(", ", Students[i].Grades) + "]}");

                if (i < Students.Count - 1)
                {
                    Console.Write(",");
                }

            }
            Console.Write("]"); 
        }
    }
}
