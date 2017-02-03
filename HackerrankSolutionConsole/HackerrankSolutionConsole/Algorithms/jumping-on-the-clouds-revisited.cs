using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class jumping_on_the_clouds_revisited : Challenge
    {
        public override void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int E = 100;
            int i = 0;
            bool started = false;
            while (!started || i != 0)
            {
                started = true;

                //do the jump
                i = (i + k) % n;

                //calculate e
                E -= (c[i] == 1) ? 3 : 1;
            }

            Console.WriteLine(E);
        }
        public jumping_on_the_clouds_revisited()
        {
            Name = "Jumping on the Clouds: Revisited";
            Path = "jumping-on-the-clouds-revisited";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}
