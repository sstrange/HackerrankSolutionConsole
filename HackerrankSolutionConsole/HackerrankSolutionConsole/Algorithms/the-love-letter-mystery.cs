using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class the_love_letter_mystery : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int steps = 0;
                string input = Console.ReadLine();
                int c = (int)Math.Floor((decimal)input.Length / 2);
                for (int j = 0; j < c; j++)                         //for strings of odd lengths, this will not go to the center char, as we don't care about that one
                {
                    char c1 = input[j];
                    char c2 = input[input.Length - j - 1];
                    char lc, sc;
                    if (c1 > c2)
                    {
                        lc = c1;
                        sc = c2;
                    }
                    else
                    {
                        lc = c2;
                        sc = c1;
                    }

                    while (lc > sc)
                    {
                        lc--;
                        steps++;
                    }
                }
                Console.WriteLine(steps);
            }
        }
        public the_love_letter_mystery()
        {
            Name = "The Love Letter Mystery";
            Path = "the-love-letter-mystery";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
