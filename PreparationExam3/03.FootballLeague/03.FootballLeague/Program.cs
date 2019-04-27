using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _03.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {

            var key = Regex.Escape(Console.ReadLine());
            var TeamScores = new Dictionary<string, int>();
            var TeamGoals = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "final")
            {
                var pattern = key + "([a-zA-Z]*)" + key + ".*" + key + "([a-zA-Z]*)" + key + ".*" + @"(\d)" + ":" + @"(\d)$";
                var success = Regex.Match(input, pattern);
                MatchCollection matches = Regex.Matches(input, pattern);
                if (!success.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var firstTeam = (matches[0].Groups[1].Value).ToUpper();
                var secondTeam = (matches[0].Groups[2].Value).ToUpper();
                var firstScore = int.Parse(matches[0].Groups[3].Value);
                var secondScore = int.Parse(matches[0].Groups[4].Value);
                var firstTeamChar = firstTeam.ToCharArray();
                var secondTeamChar = secondTeam.ToCharArray();

                Array.Reverse(firstTeamChar);
                Array.Reverse(secondTeamChar);

                var firstTeamWord = new string(firstTeamChar);
                var secondTeamWord = new string(secondTeamChar);

                //Console.WriteLine(firstTeamWord.ToString());
                //Console.WriteLine(firstTeamWord.ToString());
                if (!TeamScores.ContainsKey(firstTeamWord.ToString()))
                {
                    TeamScores[firstTeamWord.ToString()] = 0;
                    TeamGoals[firstTeamWord.ToString()] = 0;
                }

                if (!TeamScores.ContainsKey(secondTeamWord.ToString()))
                {
                    TeamScores[secondTeamWord.ToString()] = 0;
                    TeamGoals[secondTeamWord.ToString()] = 0;
                }

                if (firstScore > secondScore)
                {
                    TeamScores[firstTeamWord.ToString()] += 3;
                }
                if (firstScore == secondScore)
                {
                    TeamScores[firstTeamWord.ToString()] += 1;
                    TeamScores[secondTeamWord.ToString()] += 1;
                }
               if (secondScore>firstScore)
                {
                    TeamScores[secondTeamWord.ToString()] += 3;
                }

                TeamGoals[firstTeamWord.ToString()] += firstScore;
                TeamGoals[secondTeamWord.ToString()] += secondScore;
                //Console.WriteLine("{0}{1}{2}{3}", firstTeam, firstScore, secondTeam, secondScore);

                input = Console.ReadLine();
            }

            var finalScores = TeamScores.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            var finalGoals = TeamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            
            var counterScores = 1;

            Console.WriteLine("League standings:");
            foreach (var team in finalScores)
            {
                Console.WriteLine("{0}. {1} {2}",counterScores,team.Key,team.Value);
                counterScores++;
            }
            Console.WriteLine("Top 3 scored goals:");
            counterScores = 0;
            foreach (var team in finalGoals.Take(3))
            {
                if (counterScores==3)
                {
                    break;
                }
                Console.WriteLine("- {0} -> {1}",team.Key,team.Value);
                counterScores++;
            }
        }
    }
}
