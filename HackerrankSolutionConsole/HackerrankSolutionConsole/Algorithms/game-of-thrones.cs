using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class game_of_thrones : Challenge
    {
        public override void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int[] sb = new int[26];
            foreach (char c in input)
                sb[c - 'a']++;

            int odds = 0;
            foreach (int i in sb)
                if (i % 2 == 1)
                    odds++;

            Console.WriteLine(odds > 1 ? "NO" : "YES");
        }
        public game_of_thrones()
        {
            Name = "Game of Thrones - I";
            Path = "game-of-thrones";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}

