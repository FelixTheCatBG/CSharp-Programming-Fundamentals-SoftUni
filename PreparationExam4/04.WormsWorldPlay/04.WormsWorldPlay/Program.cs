using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WormsWorldPlay
{
    //public class Worm{

    //    public string Name {get;set;}
    //    public int Name { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var teamScores = new Dictionary<string, List<long>>();
            var Teams = new Dictionary<string, Dictionary<string,long>>();
            var wormNames = new List<String>();
            //var Scores = new Dictionary<string,List<int>>();
            
            while (input !="quit")
            {
                var inputStrings = input.Split(new[] { '>', '-',}, StringSplitOptions.RemoveEmptyEntries).ToList();

                var team = inputStrings[1].Trim(' ');
                var wormName = inputStrings[0].Trim(' ');
                var wormScore = long.Parse(inputStrings[2].Trim(' '));
               
             
                if (wormNames.Contains(wormName))
                {
                    input = Console.ReadLine();
                    continue;
                }
                
                if (!Teams.ContainsKey(team))
                {
                    Teams[team] = new Dictionary<string,long>();
                    teamScores[team] = new List<long>() ;
                }

                Teams[team][wormName] = wormScore;
                teamScores[team].Add(wormScore);

                wormNames.Add(wormName);
                
            input = Console.ReadLine();
            }
            teamScores = teamScores.OrderByDescending(x => x.Value.Sum()).ThenByDescending(x =>x.Value.Sum()/ x.Value.Count).ToDictionary(x => x.Key,x => x.Value);

            
            var counter = 1;
            foreach (var item in teamScores)
            {
                Console.WriteLine("{0}. Team: {1} - {2}",counter,item.Key,item.Value.Sum());

                foreach (var worm in Teams[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("###{0} : {1}",worm.Key,worm.Value);
                }
                counter++;
            }
           
        }

       
    }
}
