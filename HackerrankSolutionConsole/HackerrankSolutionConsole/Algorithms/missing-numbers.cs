using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class missing_numbers : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(inputs, Int32.Parse);

            int m = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(inputs, Int32.Parse);

            List<int> C = new List<int>();
            int[] B_distinct = B.Distinct().ToArray();
            foreach (int i in B_distinct)
            {
                int occurrsInA = A.Where(j => j == i).Count();
                int occurrsInB = B.Where(j => j == i).Count();
                if (occurrsInB > occurrsInA)
                    C.Add(i);
            }

            var results = C.Distinct().OrderBy(i => i).ToArray();
            Console.WriteLine(string.Join(" ", results));
        }
        public missing_numbers()
        {
            Name = "Missing Numbers";
            Path = "missing-numbers";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Search;
        }
    }

}
