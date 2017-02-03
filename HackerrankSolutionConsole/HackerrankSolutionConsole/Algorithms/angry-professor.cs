using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class angry_professor : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(inputs, Int32.Parse);
                int s = arr[0];
                int k = arr[1];

                inputs = Console.ReadLine().Split(' ');
                arr = Array.ConvertAll(inputs, Int32.Parse);
                int onTime = arr.Where(a => a <= 0).Count();
                if (onTime < k)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
        }
        public angry_professor()
        {
            Name = "Angry Professor";
            Path = "angry-professor";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}