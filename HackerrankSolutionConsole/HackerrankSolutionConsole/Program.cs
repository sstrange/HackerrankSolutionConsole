﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class Solution
    {
        public delegate void SolutionDelegate(string[] args);

        static void Main(string[] args)
        {
           
            Algorithms.MiniMaxSum(args);
        }
    }
}
