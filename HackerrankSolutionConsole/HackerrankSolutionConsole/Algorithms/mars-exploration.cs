using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class mars_exploration : Challenge
    {
        public override void Main(string[] args)
        {
            string S = Console.ReadLine();


            int errorCount = 0;
            for (int i = 0; i < S.Length; i = i + 3)
            {
                if (S[i] != 'S') errorCount++;
                if (S[i + 1] != 'O') errorCount++;
                if (S[i + 2] != 'S') errorCount++;
            }
            Console.WriteLine(errorCount);
        }
        public mars_exploration()
        {
            Name = "Mars Exploration";
            Path = "mars-exploration";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
