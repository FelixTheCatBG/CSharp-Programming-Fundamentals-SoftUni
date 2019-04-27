using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var Dict = new Dictionary<string,Dictionary<string,long>>();
            
            for (int i = 0; i < n; i++)
            {
                var firstInput = Console.ReadLine();
                var roots = firstInput.Split('\\').ToArray();

                var root = roots[0];

                var fileAndSize = roots[roots.Length - 1];
                var fileAndSizeString = fileAndSize.Split(new[] {';'}).ToArray();

                var fileName = fileAndSizeString[0];
               
                var fileSize = long.Parse(fileAndSizeString[1]);

                if (!Dict.ContainsKey(root))
                {
                    Dict[root] = new Dictionary<string, long>();
                }
                Dict[root][fileName] = fileSize;
                
            }

            var query = Console.ReadLine()
                .Split(new[] { ' ', 'n', 'i' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var lookingExt = query[0];
            var lookingRoot = query[1];

                 if (!Dict.ContainsKey(lookingRoot))
	            {
		             Console.WriteLine("No");
                            Environment.Exit(1);
	            }
            
                   var resultDictionary = Dict[lookingRoot]
                .Where(x => x.Key.EndsWith(lookingExt))
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value); 
 
            if ( resultDictionary.Count == 0 )
            {
                Console.WriteLine("No");
                Environment.Exit(1);
            }
 
            foreach ( var file in resultDictionary )
            {
                Console.WriteLine("{0} - {1} KB",file.Key,file.Value);
            }                
            
        }
    }
}
