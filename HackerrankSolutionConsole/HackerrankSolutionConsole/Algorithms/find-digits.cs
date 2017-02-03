using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class find_digits : Challenge
    {
        public override void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string nStr = Console.ReadLine();
                int n = Convert.ToInt32(nStr);
                int count = 0;
                foreach (char c in nStr)
                {
                    int cInt = (int)Char.GetNumericValue(c);
                    count += (cInt != 0 && n % cInt == 0) ? 1 : 0;

                }
                Console.WriteLine(count);
            }
        }
        public find_digits()
        {
            Name = "Find Digits";
            Path = "find-digits";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}
