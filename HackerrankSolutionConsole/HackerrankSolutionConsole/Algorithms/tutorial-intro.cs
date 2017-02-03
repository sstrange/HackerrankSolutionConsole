using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class tutorial_intro : Challenge
    {
        public override void Main(string[] args)
        {
            int V = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split(' ');          //read multiple things on a line as strings
            int[] arr = Array.ConvertAll(inputs, Int32.Parse);

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == V)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        public tutorial_intro()
        {
            Name = "Tutorial Intro";
            Path = "tutorial-intro";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Sorting;
        }
    }

}
