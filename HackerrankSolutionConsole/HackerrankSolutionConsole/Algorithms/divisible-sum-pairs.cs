using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class divisible_sum_pairs : Challenge
    {
        public override void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int firstNum = a[i];
                for (int j = i + 1; j < n; j++)
                {
                    if ((firstNum + a[j]) % k == 0)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
        public divisible_sum_pairs()
        {
            Name = "Divisible Sum Pairs";
            Path = "divisible-sum-pairs";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}