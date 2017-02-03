using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole.Algorithms
{
    class utopian_tree : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int g = Convert.ToInt32(Console.ReadLine());
                int h = 1;
                for (int j = 1; j <= g; j++)
                    if (j % 2 == 1)
                        h *= 2;
                    else
                        h += 1;


                Console.WriteLine(h);
            }
        }
        public utopian_tree()
        {
            Name = "Utopian Tree";
            Path = "utopian-tree";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}