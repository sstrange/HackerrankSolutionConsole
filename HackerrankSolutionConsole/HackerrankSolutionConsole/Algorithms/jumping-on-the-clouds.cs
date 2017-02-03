using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class jumping_on_the_clouds : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int E = 100;
            int i = 0;
            int count = 0;
            while (i < n - 1)
            {
                if (i + 2 < n && c[i + 2] != 1)
                    i += 2;
                else
                {
                    i++;
                }
                count++;
            }
            Console.WriteLine(count);
        }
        public jumping_on_the_clouds()
        {
            Name = "Jumping on the Clouds";
            Path = "jumping-on-the-clouds";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}