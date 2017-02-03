using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class insertionsort1 : Challenge
    {
        static void insertionSort(int[] ar)
        {
            int n = ar.Length;
            List<string> results = new List<string>();
            int e = ar[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                if (ar[i] > e)
                {
                    ar[i + 1] = ar[i];
                    results.Add(string.Join(" ", ar));
                    if (i == 0)
                    {
                        ar[i] = e;
                        results.Add(string.Join(" ", ar));
                    }
                }
                else
                {
                    ar[i + 1] = e;
                    results.Add(string.Join(" ", ar));
                    break;
                }
            }

            foreach (string s in results)
                Console.WriteLine(s);

        }
        public override void Main(string[] args)
        {
            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            insertionSort(_ar);
        }
        public insertionsort1()
        {
            Name = "Insertion Sort 1";
            Path = "insertionsort1";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Sorting;
        }
    }

}