using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class pangrams : Challenge
    {
        public override void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().ToLower().Distinct().Count() == 27 ? "pangram" : "not pangram");
        }
        public pangrams()
        {
            Name = "Pangrams";
            Path = "pangrams";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}
