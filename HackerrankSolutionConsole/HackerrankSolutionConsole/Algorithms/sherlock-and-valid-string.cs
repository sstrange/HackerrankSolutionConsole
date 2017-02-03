using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class sherlock_and_valid_string : Challenge
    {
        public override void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] sb = new int[26];
            foreach (char c in input)
                sb[c - 'a']++;

            int lenA = 0;
            int lenACount = 0;
            int lenB = 0;
            int lenBCount = 0;
            foreach (int i in sb)
            {
                if (i > 0)
                {
                    if (lenA == 0)
                        lenA = i;
                    if (i == lenA)
                    {
                        lenACount++;
                        continue;
                    }
                    if (lenB == 0)
                        lenB = i;
                    if (i == lenB)
                    {
                        lenBCount++;
                        continue;
                    }
                    Console.WriteLine("NO");    //if there are 3 lengths it's a no
                    return;
                }
            }

            if (lenBCount == 0                                              //all are same length
                || (lenA == 1 && lenACount == 1)                            //1 char is there once, all others are same length
                || (lenB == 1 && lenBCount == 1)
                || (lenA == lenB + 1 && lenACount == 1)           //1 char is one more than all the others. all others are same length
                || (lenB == lenA + 1 && lenBCount == 1)
                )
            {
                Console.WriteLine("YES");
                return;
            }

            Console.WriteLine("NO");
        }
        public sherlock_and_valid_string()
        {
            Name = "Sherlock and Valid String";
            Path = "sherlock-and-valid-string";
            Difficulty = Difficulty.Hard;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}

