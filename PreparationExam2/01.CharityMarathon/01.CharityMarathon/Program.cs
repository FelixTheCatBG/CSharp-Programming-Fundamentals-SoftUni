using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var numberOfRunners = long.Parse(Console.ReadLine());
            var numberOfLaps = int.Parse(Console.ReadLine());
            var lengthOfTrack = long.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            if (numberOfRunners  > capacityOfTrack * days)
            {
                numberOfRunners = capacityOfTrack * days;
            }

            var totalKm = (numberOfRunners * numberOfLaps * lengthOfTrack) / 1000;
            decimal totalMoney = (moneyPerKm * totalKm);
            Console.WriteLine("Money raised: {0:f2}",totalMoney);
        }
    }
}
