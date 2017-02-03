using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class sherlock_and_the_beast : Challenge
    {
        static string strRepeat(string str, int n)
        {
            string retStr = "";
            while (n > 0)
            {
                retStr += str;
                n--;
            }
            return retStr;
        }

        public override void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int fives = 0;
                int threes = 0;
                string number = "-1";


                int n2 = n;
                while (n2 % 3 != 0)
                {
                    n2 -= 5;
                }
                fives = n2;
                threes = n - n2;
                if (n2 >= 0)
                    number = strRepeat("5", fives) + strRepeat("3", threes);


                ////fails on 7 (555 555)
                //if (n > 2)
                //{
                //    int n2 = n;
                //    while (n2 % 3 != 0 && n2 >= 0)
                //    {
                //        n2 -= 5;
                //        threes++;
                //    }
                //    number = strRepeat("555", (int)Math.Floor((double)n2 / 3)) + strRepeat("33333", threes);
                //}

                //fails on 8 (555 33333)
                //int n2 = n;
                //while (n2>=0)
                //{
                //    if (n2%3 == 0 && n2>=3)
                //    {
                //        n2 -= 3;
                //        fives++;

                //    }
                //    else if (n2%5 == 0 && n2>=5)
                //    {
                //        n2 -= 5;
                //        threes++;
                //    }
                //    else
                //    {
                //        n2--;
                //    }
                //}
                //if (threes + fives > 0)
                //    number = strRepeat("555", fives) + strRepeat("33333", threes);

                Console.WriteLine(number);
            }
        }
        public sherlock_and_the_beast()
        {
            Name = "Sherlock and the Beast";
            Path = "sherlock-and-the-beast";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Greedy;
        }
    }

}
