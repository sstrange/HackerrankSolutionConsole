using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class strange_advertising : Challenge
    {
        public override void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int totalPeopleLiked = 0;
            int peopleSharedToday = 5;
            int peopleLikedToday;
            for (int i = 0; i < n; i++)
            {
                peopleLikedToday = (int)(peopleSharedToday / 2);
                peopleSharedToday = peopleLikedToday * 3;
                totalPeopleLiked += peopleLikedToday;
            }

            Console.WriteLine(totalPeopleLiked);
        }
        public strange_advertising()
        {
            Name = "Viral Advertising";
            Path = "strange-advertising";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}