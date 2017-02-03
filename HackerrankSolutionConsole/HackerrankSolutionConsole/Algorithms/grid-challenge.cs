using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class grid_challenge : Challenge
    {
        static bool IsSortedGrid(int N, char[][] grid)
        {
            for (int x = 0; x < N; x++)
            {
                char prevChar = '\0';
                for (int y = 0; y < N; y++)
                {
                    if (y > 0 && grid[y][x] < prevChar)
                        return false;
                    prevChar = grid[y][x];
                }
            }
            return true;
        }
        public override void Main(string[] args)
        {
            int T = Convert.ToInt16(Console.ReadLine());
            for (int n = 0; n < T; n++)
            {
                int N = Convert.ToInt16(Console.ReadLine());
                char[][] grid = new char[N][];
                for (int i = 0; i < N; i++)
                {
                    char[] inputs = Console.ReadLine().ToCharArray();
                    Array.Sort(inputs);
                    grid[i] = inputs;
                }

                if (IsSortedGrid(N, grid))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
        public grid_challenge()
        {
            Name = "Grid Challenge";
            Path = "grid-challenge";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Greedy;
        }
    }

}
