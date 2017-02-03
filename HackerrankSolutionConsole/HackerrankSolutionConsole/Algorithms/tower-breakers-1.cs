using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class tower_breakers_1 : Challenge
    {
        public override void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(inputs, Int32.Parse);
                int n = arr[0];
                int m = arr[1];
                if (m == 1 || n % 2 == 0)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("1");
            }
        }
        public tower_breakers_1()
        {
            Name = "Tower Breakers";
            Path = "tower-breakers-1";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.GameTheory;
        }
    }

}
