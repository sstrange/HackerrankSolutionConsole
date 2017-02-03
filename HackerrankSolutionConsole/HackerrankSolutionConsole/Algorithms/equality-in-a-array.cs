using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class equality_in_a_array : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int mostFreq = c.GroupBy(i => i).OrderByDescending(g => g.Count()).First().Key;
            Console.WriteLine(c.Count(i => i != mostFreq));
        }
        public equality_in_a_array()
        {
            Name = "Equalize the Array";
            Path = "equality-in-a-array";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}
