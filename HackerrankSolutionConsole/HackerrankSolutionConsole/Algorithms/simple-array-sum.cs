using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class simple_array_sum : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int sum = 0;
            //foreach(int x in arr)
            //    sum += x;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            Console.WriteLine(sum);
        }
        public simple_array_sum()
        {
            Name = "Simple Array Sum";
            Path = "simple-array-sum";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Warmup;
        }
    }

}