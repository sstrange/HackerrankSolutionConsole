using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class greedy_florist : Challenge
    {
        public override void Main(string[] args)
        {
            int N, K;
            string NK = Console.ReadLine();
            string[] NandK = NK.Split(new Char[] { ' ', '\t', '\n' });
            N = Convert.ToInt32(NandK[0]);
            K = Convert.ToInt32(NandK[1]);

            int[] C = new int[N];

            string numbers = Console.ReadLine();
            string[] split = numbers.Split(new Char[] { ' ', '\t', '\n' });

            int i = 0;

            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    C[i++] = Convert.ToInt32(s);
                }
            }
            int result = 0;

            Array.Sort(C);
            //Array.Reverse(C);


            //for (i = 0; i < N; i++)
            //{
            //    int multiple = (int) Math.Floor((decimal) N/(decimal)K +1) - (int) Math.Floor( (decimal) i/(decimal)K +1);
            //    result += C[i]*multiple;
            //}

            Array.Reverse(C);
            int multipleCounter = 0;
            int multiple = 1;
            for (i = 0; i < N; i++)
            {
                multipleCounter++;
                if (multipleCounter > K)
                {
                    multiple++;
                    multipleCounter = 1;
                }
                result += C[i] * multiple;
            }

            Console.WriteLine(result);
        }
        public greedy_florist()
        {
            Name = "Greedy Florist";
            Path = "greedy-florist";
            Difficulty = Difficulty.Medium;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Greedy;
        }
    }

}
