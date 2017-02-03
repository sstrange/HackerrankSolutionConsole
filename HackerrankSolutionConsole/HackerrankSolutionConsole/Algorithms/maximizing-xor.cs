using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class maximizing_xor : Challenge
    {
        static int maxXor(int l, int r)
        {
            int maxValue = 0;
            for (int lTemp = l; lTemp <= r; lTemp++)
            {
                for (int rTemp = lTemp; rTemp <= r; rTemp++)
                {
                    int xorValue = lTemp ^ rTemp;
                    //Console.WriteLine(lTemp + " XOR " + rTemp + " = " + xorValue);
                    if (xorValue > maxValue)
                        maxValue = xorValue;
                }
            }
            return maxValue;

        }
        public override void Main(string[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }
        public maximizing_xor()
        {
            Name = "Maximizing XOR";
            Path = "maximizing-xor";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.BitManipulation;
        }
    }

}