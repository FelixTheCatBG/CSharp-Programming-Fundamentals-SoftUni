using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SoftUniCoffee
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var dateString = Console.ReadLine();
                var dateResult = DateTime.ParseExact(dateString, "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = decimal.Parse(Console.ReadLine());

                int days = DateTime.DaysInMonth(dateResult.Year, dateResult.Month);

                decimal orderPrice = ((days * capsulesCount) * pricePerCapsule);
                
                totalPrice += orderPrice;

                Console.WriteLine("The price for the coffee is: ${0:f2}",orderPrice);
            }
            Console.WriteLine("Total: ${0:f2}",totalPrice);
        }
    }
}
