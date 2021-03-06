﻿using System;
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
        public Subdomain Subdomain;
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
    
    public enum Subdomain 
    {
        //Algorithms
        Warmup,
        Implementation, 
        Constructive,
        Strings,
        Sorting,
        Search,
        GraphTheory,
        Greedy,
        DynamicProg,
        BitManipulation,
        Recursion,
        GameTheory,
        NPComplete,

    }

    public class AnotherChallenge : Challenge
    {
        public override void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("this is Another Challenge main output");
                System.Threading.Thread.Sleep(1000);
            }
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
