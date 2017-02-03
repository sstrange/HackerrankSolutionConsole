using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class icecream_parlor : Challenge
    {
        public override void Main(string[] args)
        {
            List<string> results = new List<string>();
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] inputs = Console.ReadLine().Split(' ');
                int[] flavors = Array.ConvertAll(inputs, Int32.Parse);

                //populate dictionary
                Dictionary<int, int> flavDict = new Dictionary<int, int>();
                for (int j = 0; j < n; j++)
                {
                    if (flavDict.ContainsKey(flavors[j]))       //in case of duplicates, store the last found one
                        flavDict[flavors[j]] = j + 1;
                    else
                        flavDict.Add(flavors[j], j + 1);
                }

                for (int j = 0; j < n; j++)
                {
                    int firstFlavorPrice = flavors[j];
                    int neededSecondPrice = m - flavors[j];
                    if (flavDict.ContainsKey(neededSecondPrice) && flavDict[neededSecondPrice] != j + 1)
                    {
                        results.Add((j + 1).ToString() + " " + flavDict[neededSecondPrice]);
                        break;
                    }
                }
            }

            foreach (string s in results)
                Console.WriteLine(s);
        }
        public icecream_parlor()
        {
            Name = "Ice Cream Parlor";
            Path = "icecream-parlor";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Search;
        }
    }

}
