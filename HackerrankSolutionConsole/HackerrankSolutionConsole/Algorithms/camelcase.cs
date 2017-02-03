using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class camelcase : Challenge
    {
        public override void Main(string[] args)
        {
            string input = Console.ReadLine();
            int uppercase = input.Count(c => Char.IsUpper(c));
            Console.WriteLine(uppercase + 1);
        }
        public camelcase()
        {
            Name = "Camelcase";
            Path = "camelcase";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Strings;
        }
    }

}