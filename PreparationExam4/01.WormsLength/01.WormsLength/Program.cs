using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WormsLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthM = int.Parse(Console.ReadLine());
            var widthCm = decimal.Parse(Console.ReadLine());

            decimal lengthCm = lengthM * 100;

            var reminder = (decimal)lengthCm % widthCm;

            if (reminder <= 0 )
            {
                ulong product =(ulong)(lengthCm * widthCm);

                Console.WriteLine("{0:f2}",product);
                
            }
            else
            {
                var percentage = (lengthCm / widthCm) * 100;
                Console.WriteLine("{0:f2}%",percentage);
            }
        }
    }
}
