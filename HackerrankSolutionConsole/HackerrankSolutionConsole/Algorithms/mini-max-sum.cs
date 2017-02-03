using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    public class mini_max_sum : Challenge
    {
        public override void Main(string[] args)
        {
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            Array.Sort(c);
            long largesum = 0;
            long smallsum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i != 0)
                    largesum += c[i];
                if (i != 4)
                    smallsum += c[i];
            }
            Console.WriteLine(smallsum.ToString() + " " + largesum.ToString());

        }
        public mini_max_sum()
        {
            Name = "Mini-Max Sum";
            Path = "mini-max-sum";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}
