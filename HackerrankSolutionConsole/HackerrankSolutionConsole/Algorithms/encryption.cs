using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class encryption : Challenge
    {
        public override void Main(string[] args)
        {
            string s = Console.ReadLine();
            int L = s.Length;

            int floor = (int)Math.Floor(Math.Sqrt(L));
            int ceiling = (int)Math.Ceiling(Math.Sqrt(L));

            int rows, columns;
            if (floor * floor >= L)
            {
                rows = floor;
                columns = floor;
            }
            else if (floor * ceiling >= L)
            {
                columns = ceiling;
                rows = floor;
            }
            else
            {
                rows = ceiling;
                columns = ceiling;
            }

            char[,] grid = new char[columns, rows];
            int x = 0;
            int y = 0;
            foreach (char c in s)
            {
                grid[x, y] = c;
                x++;
                if (x == columns)
                {
                    x = 0;
                    y++;
                }
            }

            string sentence = string.Empty;
            for (int i = 0; i < columns; i++)
            {
                string word = "";
                for (int j = 0; j < rows; j++)
                {
                    if (Char.IsLetter(grid[i, j]) && grid[i, j] < 128)
                        word += grid[i, j];

                }

                sentence += word + " ";
            }
            Console.WriteLine(sentence.Trim());
        }
        public encryption()
        {
            Name = "Encryption";
            Path = "encryption";
            Difficulty = Difficulty.Medium;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Implementation;
        }
    }

}
