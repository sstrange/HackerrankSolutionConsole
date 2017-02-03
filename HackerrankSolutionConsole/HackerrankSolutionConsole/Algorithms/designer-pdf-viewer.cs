using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class designer_pdf_viewer : Challenge
    {
        public override void Main(string[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();

            var maxValue = 1;
            foreach (char c in word.Distinct())
            {
                if (h[c - 97] > maxValue)
                    maxValue = h[c - 97];
            }

            Console.WriteLine(maxValue * word.Length);
        }
        public designer_pdf_viewer()
        {
            Name = "Designer PDF Viewer";
            Path = "designer-pdf-viewer";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}