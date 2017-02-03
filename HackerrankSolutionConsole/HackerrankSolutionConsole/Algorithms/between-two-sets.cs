using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class between_two_sets : Challenge
    {
        public override void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            List<int> x = new List<int>();

            //build list of nums that are factors of all nums in b
            //start with factors of smallest number
            Array.Sort(b);
            for (int i = 1; i <= b[0]; i++)
            {
                if (b[0] % i == 0)
                    x.Add(i);
            }
            //remove the ones that are not also factors of every other number in b
            for (int i = 1; i < m; i++)
            {
                x = x.Where(numX => b[i] % numX == 0).ToList();
                //foreach(int f in x)
                //{
                //    if (b[i] % f != 0)
                //        x.Remove(f);
                //}
            }


            //remove the ones that all the nums in a are not factors of
            foreach (int numA in a)
            {
                x = x.Where(numX => numX % numA == 0).ToList();
            }

            //Console.WriteLine(string.Join(" ",x));
            Console.WriteLine(x.Count);
        }
        public between_two_sets()
        {
            Name = "Between Two Sets";
            Path = "between-two-sets";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}