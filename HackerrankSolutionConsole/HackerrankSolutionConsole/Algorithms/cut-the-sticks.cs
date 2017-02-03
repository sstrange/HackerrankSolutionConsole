using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class cut_the_sticks : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int sticksLeft = arr.Length;
            Array.Sort(arr);
            int currentStickLength = -1;
            int sticksOfCurrentLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != currentStickLength)
                {
                    sticksLeft -= sticksOfCurrentLength;
                    Console.WriteLine(sticksLeft);
                    currentStickLength = arr[i];
                    sticksOfCurrentLength = 1;
                }
                else
                {
                    sticksOfCurrentLength++;
                }
            }
        }
        public cut_the_sticks()
        {
            Name = "Cut the Sticks";
            Path = "cut-the-sticks";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}