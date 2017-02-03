using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class gem_stones : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            List<char> gemElements = input.Distinct().ToList();
            for (int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine();
                List<char> prevGemElements = new List<char>(gemElements);
                foreach (char c in prevGemElements)
                {
                    if (!input.Contains(c))
                        gemElements.Remove(c);
                }
            }
            Console.WriteLine(gemElements.Count);
            //Console.ReadLine();
        }
        public gem_stones()
        {
            Name = "Gemstones";
            Path = "gem-stones";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
