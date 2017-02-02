using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    //partial class Algorithms
    //{
    //    public static void MiniMaxSum(string[] args)
    //    {
    //        Console.WriteLine("this is Min Max Sum");
    //        Console.ReadLine();
    //    }
    //}


    public class MiniMaxSum : Challenge
    {
        public override void Main(string[] args)
        {
            Console.WriteLine("this is Min Max Sum main output");
           
        }
        public MiniMaxSum()
        {
            Name = "Mini-Max Sum";
            Path = "mini-max-sum";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
        
    }


    public class AnotherChallenge : Challenge
    {
        public override void Main(string[] args)
        {
            Console.WriteLine("this is Another Challenge main output");
            Console.ReadLine();
        }
        public AnotherChallenge(int num)
        {
            Name = "Another Challenge " + num;
            Path = "mini-max-sum";
            Difficulty = Difficulty.Hard;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.BitManipulation;
        }

    }

}
