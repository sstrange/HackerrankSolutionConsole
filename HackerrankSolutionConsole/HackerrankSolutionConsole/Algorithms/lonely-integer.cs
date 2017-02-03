using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class lonely_integer : Challenge
    {
        static int lonelyinteger(int[] a)
        {
            foreach (int i in a)
            {
                if (a.Where(j => j == i).Count() == 1)
                    return i;
            }
            return 0;
        }
        public override void Main(string[] args)
        {
            int res;

            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }
            res = lonelyinteger(_a);
            Console.WriteLine(res);
        }
        public lonely_integer()
        {
            Name = "Lonely Integer";
            Path = "lonely-integer";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.BitManipulation;
        }
    }

}
