using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class beautiful_days_at_the_movies : Challenge
    {
        public override void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int i = arr[0];
            int j = arr[1];
            int k = arr[2];

            int count = 0;
            for (int day = i; day <= j; day++)
            {
                string dayreversed = new string(day.ToString().ToCharArray().Reverse().ToArray());

                int reverse = Convert.ToInt32(dayreversed);

                //int reverse = Convert.ToInt32(day.ToString().Reverse().ToString());

                double x = Math.Abs((double)(day - reverse)) / k;
                if (x.Equals(Math.Floor(x)))
                    count++;
            }
            Console.WriteLine(count);
        }
        public beautiful_days_at_the_movies()
        {
            Name = "Beautiful Days at the Movies";
            Path = "beautiful-days-at-the-movies";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}
