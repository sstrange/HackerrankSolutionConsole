using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class plus_minus : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            decimal posCount = (decimal)arr.Where(i => i > 0).Count();
            decimal negCount = (decimal)arr.Where(i => i < 0).Count();
            decimal zerCount = (decimal)arr.Where(i => i == 0).Count();

            decimal posFrac = posCount / n;
            decimal negFrac = negCount / n;
            decimal zerFrac = zerCount / n;

            Console.WriteLine(posFrac.ToString());
            Console.WriteLine(negFrac.ToString());
            Console.WriteLine(zerFrac.ToString());
        }
        public plus_minus()
        {
            Name = "Plus Minus";
            Path = "plus-minus";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Warmup;
        }
    }

}
   