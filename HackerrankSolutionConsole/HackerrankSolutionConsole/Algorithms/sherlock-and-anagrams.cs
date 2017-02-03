using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class sherlock_and_anagrams : Challenge
    {
        private static bool IsAnagram(string a, string b)
        {
            int[] aFreq = new int[26];
            int[] bFreq = new int[26];
            //for (int i = 0; i < first.Length; i++) { first[i] = 0; }
            //for (int i = 0; i < second.Length; i++) { second[i] = 0; }
            foreach (char c in a)
                aFreq[c - 97]++;
            foreach (char c in b)
                bFreq[c - 97]++;

            for (int i = 0; i < 26; i++)
                if (aFreq[i] != bFreq[i])
                    return false;
            return true;
        }
        public override void Main(string[] args)
        {
            int T = Convert.ToInt16(Console.ReadLine());
            for (int n = 0; n < T; n++)
            {
                int count = 0;
                string input = Console.ReadLine().Trim();

                for (int j = 0; j < input.Length - 1; j++)
                {
                    for (int len = 1; len < input.Length - j; len++)
                    {
                        string substrSm = input.Substring(j, len);
                        string substrLg = input.Substring(j + 1);
                        for (int k = 0; k <= substrLg.Length - substrSm.Length; k++)
                        {
                            if (IsAnagram(substrLg.Substring(k, substrSm.Length), substrSm))
                                count++;
                        }
                    }
                }
                Console.WriteLine(count);
            }
        }
        public sherlock_and_anagrams()
        {
            Name = "Sherlock and Anagrams";
            Path = "sherlock-and-anagrams";
            Difficulty = Difficulty.Medium;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
