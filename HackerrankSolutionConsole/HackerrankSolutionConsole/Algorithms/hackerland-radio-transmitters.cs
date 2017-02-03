using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class hackerland_radio_transmitters : Challenge
    {
        public override void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(inputs, Int32.Parse);
            int n = arr[0];
            int k = arr[1];
            //inputs = Console.ReadLine().Split(' ');
            var x = Console.ReadLine().Split(' ').Select(y => Convert.ToInt32(y)).Distinct().OrderBy(y => y).ToList();

            //List<int> distances = new List<int>();
            //int currentHouse = x[0];
            //for(int i = 1; i<n; i++)
            //{
            //    distances.Add(x[i] - currentHouse);
            //}

            //int numOfTrans = 0;

            //int distSinceTrans = 0;
            //for (int i = 0; i < distances.Count; i++)
            //{
            //    bool covered = (numOfTrans > 0 && distSinceTrans + distances[i] <= k);


            //    if (distSinceTrans + distances[i] < k)
            //        distSinceTrans += distances[i];
            //    else
            //    {
            //        numOfTrans++;
            //        distSinceTrans = 0;
            //    }
            //}
            //Console.WriteLine(numOfTrans);


            //List<int> transmitters = new List<int>();
            //int distSinceTrans = 0;
            //for (int i = x.Min(); i<= x.Max(); i++)
            //{
            //    distSinceTrans++;
            //    bool covered = (transmitters.Count > 0 && distSinceTrans <= k);
            //    if (x.Contains(i) && !covered)
            //    {
            //        int potentialReach = i + k;
            //        bool betterSpotFound = false;
            //        for(; potentialReach > i; potentialReach--)
            //        {
            //            if (x.Contains(i))
            //            {
            //                betterSpotFound = true;
            //                break;
            //            }
            //        }
            //        if (!betterSpotFound)
            //        {
            //            //add trans
            //        }
            //    }
            //}

            int transCount = 0;
            int lastTrans = 0;
            int index = 0;
            foreach (int currentHouse in x)
            {
                bool covered = (transCount > 0) && (currentHouse <= lastTrans + k);
                if (!covered)
                {
                    lastTrans = currentHouse;
                    for (int i = index + 1; i < x.Count; i++)
                    {
                        if (x[i] <= currentHouse + k)
                            lastTrans = x[i];
                        else
                            break;
                    }
                    transCount++;
                }
                index++;
            }
            Console.WriteLine(transCount);
        }
        public hackerland_radio_transmitters()
        {
            Name = "Hackerland Radio Transmitters";
            Path = "hackerland-radio-transmitters";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Search;
        }
    }

}
