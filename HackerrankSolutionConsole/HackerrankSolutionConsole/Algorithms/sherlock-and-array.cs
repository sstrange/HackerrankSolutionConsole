using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class sherlock_and_array : Challenge
    {
        public override void Main(string[] args)
        {
            List<string> results = new List<string>();
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] inputs = Console.ReadLine().Split(' ');
                int[] A = Array.ConvertAll(inputs, Int32.Parse);

                string result = "NO";
                int leftSum = 0;
                int rightSum = A.Sum();
                foreach (int j in A)
                {
                    rightSum -= j;
                    if (rightSum == leftSum)
                    {
                        result = "YES";
                        break;
                    }
                    leftSum += j;
                }
                results.Add(result);
            }

            foreach (string s in results)
                Console.WriteLine(s);
        }
        public sherlock_and_array()
        {
            Name = "Sherlock and Array";
            Path = "sherlock-and-array";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Search;
        }
    }

}
