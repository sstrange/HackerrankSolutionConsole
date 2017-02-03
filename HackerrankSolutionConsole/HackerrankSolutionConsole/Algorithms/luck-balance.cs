using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class luck_balance : Challenge
    {
        public override void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');          //read multiple things on a line as array of strings
            int N = Convert.ToInt32(inputs[0]);
            int K = Convert.ToInt32(inputs[1]);

            int L, T = 0;
            List<int> important = new List<int>();
            List<int> unimportant = new List<int>();
            for (int i = 0; i < N; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                L = Convert.ToInt32(inputs[0]);
                T = Convert.ToInt32(inputs[1]);
                if (T == 1)
                    important.Add(L);
                else
                    unimportant.Add(L);
            }
            important = important.OrderByDescending(x => x).ToList();
            //important.Sort();
            //important.Reverse();

            int luck = 0;
            for (int i = 0; i < important.Count(); i++)
                if (i < K)
                {
                    //Console.WriteLine("+ " + important[i]);

                    luck += important[i];
                }
                else
                {
                    //Console.WriteLine("- " + important[i]);
                    luck -= important[i];
                }


            //Console.WriteLine("+ " + unimportant.Sum());
            luck += unimportant.Sum();
            Console.WriteLine(luck);
        }
        public luck_balance()
        {
            Name = "Luck Balance";
            Path = "luck-balance";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Greedy;
        }
    }

}
