using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    public abstract class Challenge
    {
        //public Challenge(string name, string path, Difficulty difficulty, Domain domain, SolutionDelegate solution)
        //{
        //    Name = name;
        //    Path = path;
        //    Difficulty = difficulty;
        //    Domain = domain;
        //    Solution = solution;
        //}
        public string Name;
        public string Path;
        public Difficulty Difficulty;
        public Domain Domain;
        //public SolutionDelegate Solution;
        public abstract void Main(string[] args);
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public enum Domain
    {
        Algorithms,
        DataStructures,
        Mathematics,
        ArtificialIntelligence,
        FunctionalProgramming
    }
}
