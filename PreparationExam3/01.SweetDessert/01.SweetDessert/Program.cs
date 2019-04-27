using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            double priceForBanana = double.Parse(Console.ReadLine());
            double priceForEgg = double.Parse(Console.ReadLine());
            double priceForBerriesKG = double.Parse(Console.ReadLine());

            var portions = 0;

            for (int i = numberOfGuests; i < numberOfGuests +7; i++)
            {
                if (i % 6 == 0)
                {
                    portions = i;
                    break;
                }
            }

            var setOfPortions = portions / 6;
            var blueberrys = (0.2 * priceForBerriesKG);
            var totalMoneyNeeded = setOfPortions * (2 * priceForBanana) + setOfPortions * (4 * priceForEgg) + setOfPortions * (blueberrys);

            if (cash >= totalMoneyNeeded)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",totalMoneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",totalMoneyNeeded - cash);
            }
        }
    }
}
