using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class game_of_stones_1 : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int stones = Convert.ToInt32(Console.ReadLine());
                if (stones % 7 >= 2)
                    Console.WriteLine("First");
                else
                    Console.WriteLine("Second");
            }

        }
        public game_of_stones_1()
        {
            Name = "Game of Stones";
            Path = "game-of-stones-1";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.GameTheory;
        }
    }

}
