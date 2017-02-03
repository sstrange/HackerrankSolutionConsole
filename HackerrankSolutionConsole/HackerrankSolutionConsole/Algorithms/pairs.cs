using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class pairs : Challenge
    {
        static int pairsHelper(int[] a, int k)
        {

            int pairCount = 0;

            //works but times out
            //foreach (int x in a)
            //    if (a.Contains(x - k))
            //        pairCount++;

            a = a.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < a.Length && a[i] >= k; i++)
            {
                for (int j = i + 1; (j < a.Length) && (a[j] >= a[i] - k); j++)
                {
                    if (a[j] == a[i] - k)
                        pairCount++;
                }
            }

            return pairCount;
        }
        public override void Main(string[] args)
        {
            int res;

            String line = Console.ReadLine();
            String[] line_split = line.Split(' ');
            int _a_size = Convert.ToInt32(line_split[0]);
            int _k = Convert.ToInt32(line_split[1]);
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }

            res = pairsHelper(_a, _k);
            Console.WriteLine(res);
        }
        public pairs()
        {
            Name = "Pairs";
            Path = "pairs";
            Difficulty = Difficulty.Medium;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Search;
        }
    }

}
