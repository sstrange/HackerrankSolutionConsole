using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class compare_the_triplets : Challenge
    {
        public override void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int aScore = 0;
            int bScore = 0;

            if (a0 != b0)
                if (a0 > b0)
                    aScore++;
                else
                    bScore++;
            if (a1 != b1)
                if (a1 > b1)
                    aScore++;
                else
                    bScore++;
            if (a2 != b2)
                if (a2 > b2)
                    aScore++;
                else
                    bScore++;

            Console.WriteLine(aScore.ToString() + " " + bScore.ToString());
        }
        public compare_the_triplets()
        {
            Name = "Compare The Triplets";
            Path = "compare-the-triplets";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Warmup;
        }
    }

}