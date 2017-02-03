using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class sum_vs_xor : Challenge
    {
        public override void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());

            //Works but times out. 
            //int count = 1;
            //for (long i = 1; i <= n; i++)
            //    if ((i + n) == (i ^ n))
            //        count++;
            //Console.WriteLine(count);

            if (n == 0)
                Console.WriteLine("1");
            else
            {

                string bin = Convert.ToString(n, 2);
                Console.WriteLine(Math.Pow(2, bin.Count(x => x == '0')));
            }
        }
        public sum_vs_xor()
        {
            Name = "Sum vs XOR";
            Path = "sum-vs-xor";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.BitManipulation;
        }
    }

}
