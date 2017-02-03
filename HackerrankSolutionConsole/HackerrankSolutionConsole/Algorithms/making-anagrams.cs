using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class making_anagrams : Challenge
    {
        public override void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int[] sb1 = new int[26];
            int[] sb2 = new int[26];

            foreach (char c in str1)
                sb1[c - 97]++;

            foreach (char c in str2)
                sb2[c - 97]++;

            int count = 0;
            for (int k = 0; k < 26; k++)
            {
                count += Math.Abs(sb1[k] - sb2[k]);
            }

            Console.WriteLine(count);
        }
        public making_anagrams()
        {
            Name = "Making Anagrams";
            Path = "making-anagrams";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
