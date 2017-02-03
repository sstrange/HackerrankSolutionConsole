using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class anagram : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input.Length % 2 == 1)
                    Console.WriteLine(-1);
                else
                {
                    char[] ar1 = input.Substring(0, input.Length / 2).ToCharArray();
                    char[] ar2 = input.Substring(input.Length / 2, input.Length / 2).ToCharArray();

                    int[] sb1 = new int[26];
                    int[] sb2 = new int[26];

                    for (int j = 0; j < input.Length / 2; j++)
                    {
                        int ascii = (int)ar1[j];
                        sb1[ascii - 97]++;
                        ascii = (int)ar2[j];
                        sb2[ascii - 97]++;
                    }

                    int count = 0;
                    for (int k = 0; k < 26; k++)
                    {
                        count += Math.Abs(sb1[k] - sb2[k]);
                    }

                    Console.WriteLine(count / 2);

                }
            }
        }
        public anagram()
        {
            Name = "Anagram";
            Path = "anagram";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
