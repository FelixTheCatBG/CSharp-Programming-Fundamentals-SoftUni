using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var bees = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornetsPower = hornets.Sum();
            
            for (int i = 0; i < bees.Count; i++)
            {
                
                
                if (bees[i] < hornetsPower)
                {
                    bees[i] = 0;
                    
                    
                }
                else{
                
                   bees[i] -= hornetsPower;
                        if (hornets.Any())
	                        {
		                         hornets.RemoveAt(0);
                                hornetsPower = hornets.Sum();
	                        }
                        else { break; }
                }
        }

            bees.RemoveAll(x => x == 0);
               
            

            if (!bees.Any())
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
            else { Console.WriteLine(string.Join(" ", bees)); }
                
        }
    }
}
