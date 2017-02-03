using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class jim_and_the_orders : Challenge
    {
        struct order
        {
            public int num;
            public int value;
        }
        public override void Main(string[] args)
        {
            List<order> orders = new List<order>();
            int T = Convert.ToInt16(Console.ReadLine());
            for (int n = 1; n <= T; n++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(inputs, Int32.Parse);
                orders.Add(new order() { num = n, value = arr[0] + arr[1] });
            }

            Console.WriteLine(String.Join(" ", orders.OrderBy(o => o.value).ThenBy(o => o.num).Select(o => o.num).ToArray()));

        }
        public jim_and_the_orders()
        {
            Name = "Jim and the Orders";
            Path = "jim-and-the-orders";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Greedy;
        }
    }

}
