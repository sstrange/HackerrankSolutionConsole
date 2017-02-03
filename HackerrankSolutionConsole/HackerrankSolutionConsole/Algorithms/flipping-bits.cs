using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class flipping_bits : Challenge
    {
        const uint mask = 4294967295;
        public override void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            List<uint> results = new List<uint>();
            for (int i = 0; i < T; i++)
            {
                uint numToFlip = Convert.ToUInt32(Console.ReadLine());
                results.Add(mask ^ numToFlip);
            }
            foreach (var r in results)
                Console.WriteLine(r);
        }
        public flipping_bits()
        {
            Name = "Flipping Bits";
            Path = "flipping-bits";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.BitManipulation;
        }
    }

}
