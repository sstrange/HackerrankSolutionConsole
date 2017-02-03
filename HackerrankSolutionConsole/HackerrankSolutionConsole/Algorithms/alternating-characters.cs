using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class alternating_characters : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputLines = new string[n];
            for (int i = 0; i < n; i++)
            {
                inputLines[i] = Console.ReadLine();
            }

            foreach (string str in inputLines)
            {
                int charsToRemove = 0;
                char compChar = str[0];
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == compChar)
                        charsToRemove++;
                    else
                        compChar = str[i];
                }
                Console.WriteLine(charsToRemove);
            }
        }
        public alternating_characters()
        {
            Name = "Alternating Characters";
            Path = "alternating-characters";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
