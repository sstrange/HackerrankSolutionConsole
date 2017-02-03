using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class save_the_prisoner : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                int P = arr[0];
                int C = arr[1];
                int S = arr[2];
                int prisoner = ((C - 1) + S) % P;
                if (prisoner == 0)
                    prisoner = P;

                Console.WriteLine(prisoner);
            }
        }
        public save_the_prisoner()
        {
            Name = "Save the Prisoner";
            Path = "save-the-prisoner";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}