using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class two_characters : Challenge
    {
        public override void Main(string[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            List<int> tlengths = new List<int>() { 0 };
            var distinctChars = s.Distinct().ToList();
            for (int i = 0; i < distinctChars.Count() - 1; i++)
            {
                char x = distinctChars[i];
                for (int j = i + 1; j < distinctChars.Count(); j++)
                {
                    char y = distinctChars[j];
                    string sWithCharRemoved = s;
                    foreach (char c in distinctChars)
                    {
                        if (c != x && c != y)
                            sWithCharRemoved = sWithCharRemoved.Replace(c.ToString(), "");
                    }
                    if (sWithCharRemoved.IsT())
                        tlengths.Add(sWithCharRemoved.Length);
                }
            }

            Console.WriteLine(tlengths.Max());
        }
        public two_characters()
        {
            Name = "Two Characters";
            Path = "two-characters";
            Difficulty = Difficulty.Medium;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

    public static class StringExtension
    {
        public static bool IsT(this string str)
        {
            if (str.Distinct().Count() != 2 || str.Count() < 2)
                return false;

            char c = str[0];
            for (int i = 1; i < str.Count(); i++)
            {
                if (str[i] == c)
                    return false;
                c = str[i];
            }
            return true;
        }
    }

}