using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class repeated_string : Challenge
    {
        public override void Main(string[] args)
        {
            string s = Console.ReadLine();
            double n = Convert.ToInt64(Console.ReadLine());

            double asInS = s.Count(c => c == 'a');
            double count = Math.Floor(n / s.Length) * asInS;
            double m = n % (double)s.Length;
            count += s.Substring(0, (int)m).Count(c => c == 'a');

            Console.WriteLine(count);
        }
        public repeated_string()
        {
            Name = "Repeated Stringr";
            Path = "repeated-string";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}