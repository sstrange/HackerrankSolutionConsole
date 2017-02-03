using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class funny_string : Challenge
    {
        public override void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());              //read multiple lines as a single array of strings
            string[] inputLines = new string[T];
            for (int i = 0; i < T; i++)
            {
                inputLines[i] = Console.ReadLine();
            }

            foreach (string S in inputLines)
            {
                string result = "Funny";
                char[] R = S.ToCharArray();
                Array.Reverse(R);

                for (int i = 1; i < S.Length; i++)
                {
                    if (Math.Abs(S[i] - S[i - 1]) != Math.Abs(R[i] - R[i - 1]))
                    {
                        result = "Not Funny";
                        break;
                    }
                }
                Console.WriteLine(result);
            }
        }
        public funny_string()
        {
            Name = "Funnt String";
            Path = "funny-string";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}