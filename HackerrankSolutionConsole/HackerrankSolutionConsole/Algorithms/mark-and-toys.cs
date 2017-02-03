using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class mark_and_toys : Challenge
    {
        public override void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int T = Convert.ToInt32(inputs[0]);
            int K = Convert.ToInt32(inputs[1]);
            inputs = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(inputs, Int32.Parse);
            Array.Sort(arr);

            int spent = 0;
            int count = 0;
            for (int n = 0; n < T; n++)
            {
                if (spent + arr[n] <= K)
                {
                    spent += arr[n];
                    count++;
                }
                //else
                //break;



            }
            Console.WriteLine(count);
        }
        public mark_and_toys()
        {
            Name = "Mark and Toys";
            Path = "mark-and-toys";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Greedy;
        }
    }

}
