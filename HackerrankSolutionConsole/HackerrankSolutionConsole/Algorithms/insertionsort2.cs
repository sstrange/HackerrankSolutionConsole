using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class insertionsort2 : Challenge
    {
        static void insertionSort(int[] ar)
        {
            int i = 1;

            while (i < ar.Length)
            {
                int hole = i;
                int e = ar[hole];

                while (hole >= 1 && ar[hole - 1] > e)
                {
                    ar[hole] = ar[hole - 1];
                    hole--;
                    //Console.WriteLine(string.Join(" ", ar));
                }
                ar[hole] = e;
                Console.WriteLine(string.Join(" ", ar));
                i++;
            }

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
        public insertionsort2()
        {
            Name = "Insertion Sort 2";
            Path = "insertionsort2";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Sorting;
        }
    }

}