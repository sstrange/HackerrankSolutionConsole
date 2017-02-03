using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class kangaroo : Challenge
    {
       
        private static string race(int x1, int v1, int x2, int v2)
        {
            //if (x2>x1 && v2>=v1)
            //   return "NO";

            if (v1 > v2 && ((x2 - x1) % (v1 - v2) == 0))
                return "YES";
            else
                return "NO";
        }

        public override void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            Console.WriteLine(race(x1, v1, x2, v2));
        }
        public kangaroo()
        {
            Name = "Kangaroo";
            Path = "kangaroo";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}