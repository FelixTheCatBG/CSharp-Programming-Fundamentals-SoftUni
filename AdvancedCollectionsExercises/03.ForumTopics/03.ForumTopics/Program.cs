using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {   
            var forumTopics = new Dictionary<string, HashSet<string>>(); 
            var input = Console.ReadLine();

            while (input != "filter")
            {
                var inputList = input.Split(new[] { ' ', '-', '>',',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var topic = inputList[0];
                
                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics[topic] = new HashSet<string>();
                }

                for (int i = 1; i < inputList.Count; i++)
                {
                    forumTopics[topic].Add(inputList[i]);
                }

               

                input = Console.ReadLine();
            }


            var input2 = Console.ReadLine();

            var inputList2 = input2.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var item in forumTopics)
            {
                var hasContain = false;

                for (int i = 0; i < inputList2.Count; i++)
                {
                    if (item.Value.Contains(inputList2[i]))
                    {
                        hasContain = true;
                    }
                    else
                    {
                        hasContain = false;
                        break;
                    }
                }

                if (hasContain)
                {
                    Console.WriteLine("{0} | {1}", item.Key, string.Join(", #", item.Value));
                }
            }

         }
    }
}
