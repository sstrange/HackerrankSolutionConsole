using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class staircase : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string step = "";
            for (int i = 0; i < n; i++)
            {
                step += "#";
                Console.WriteLine(step.PadLeft(n, ' '));
            }
        }
        public staircase()
        {
            Name = "Staircase";
            Path = "staircase";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Warmup;
        }
    }

}