using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    public class ChallengeDataHelper 
    {
        private readonly List<Challenge> _challengeList;
        
        public ChallengeDataHelper()
        {
            _challengeList = BuildChallengeList();
        }

        public List<Challenge> AllChallenges
        {
            get { return _challengeList; }
        }
        public List<Challenge> Algorithms
        {
            get{ return _challengeList.Where(c => c.Domain == Domain.Algorithms).ToList(); }
        }
        public List<Challenge> ArtificialIntelligence
        {
            get { return _challengeList.Where(c => c.Domain == Domain.ArtificialIntelligence).ToList(); }
        }
        public List<Challenge> DataStructures
        {
            get { return _challengeList.Where(c => c.Domain == Domain.DataStructures).ToList(); }
        }
        public List<Challenge> FunctionalProgramming
        {
            get { return _challengeList.Where(c => c.Domain == Domain.FunctionalProgramming).ToList(); }
        }
        public List<Challenge> Mathematics
        {
            get { return _challengeList.Where(c => c.Domain == Domain.Mathematics).ToList(); }
        }
        public List<Challenge> Easy
        {
            get { return _challengeList.Where(c => c.Difficulty == Difficulty.Easy).ToList(); }
        }
        public List<Challenge> Medium
        {
            get { return _challengeList.Where(c => c.Difficulty == Difficulty.Medium).ToList(); }
        }
        public List<Challenge> Hard
        {
            get { return _challengeList.Where(c => c.Difficulty == Difficulty.Hard).ToList(); }
        }
        //public List<Challenge> GetAllChallenges()
        //{
        //    return _challengeList;
        //}

        //public List<Challenge> GetAlgorithms()
        //{
        //    return _challengeList.Where(c => c.Domain == Domain.Algorithms).ToList();
        //}

        //public List<Challenge> GetArtificialIntelligence()
        //{
        //    return _challengeList.Where(c => c.Domain == Domain.ArtificialIntelligence).ToList();
        //}

        //public List<Challenge> GetDataStructures()
        //{
        //    return _challengeList.Where(c => c.Domain == Domain.DataStructures).ToList();
        //}

        //public List<Challenge> GetFunctionalProgramming()
        //{
        //    return _challengeList.Where(c => c.Domain == Domain.FunctionalProgramming).ToList();
        //}

        //public List<Challenge> GetMathematics()
        //{
        //    return _challengeList.Where(c => c.Domain == Domain.Mathematics).ToList();
        //}

        //public List<Challenge> GetEasy()
        //{
        //    return _challengeList.Where(c => c.Difficulty == Difficulty.Easy).ToList();
        //}

        //public List<Challenge> GetMedium()
        //{
        //    return _challengeList.Where(c => c.Difficulty == Difficulty.Medium).ToList();
        //}

        //public List<Challenge> GetHard()
        //{
        //    return _challengeList.Where(c => c.Difficulty == Difficulty.Hard).ToList();
        //}

        public List<Challenge> Search(string searchString)
        {
            return _challengeList.Where(c => c.Name.ToLower().Contains(searchString.ToLower())).ToList();
        }

        private List<Challenge> BuildChallengeList()
        {
            return new List<Challenge>
            {
                new MiniMaxSum(),
                new AnotherChallenge(1),
                new AnotherChallenge(2),
                new AnotherChallenge(3),
                new AnotherChallenge(4),
                new AnotherChallenge(5),
                new AnotherChallenge(6),
                new AnotherChallenge(7),
                new AnotherChallenge(8),
                new AnotherChallenge(9),
                new AnotherChallenge(10),
                new AnotherChallenge(11),
                new AnotherChallenge(12),
                new AnotherChallenge(13),
                new AnotherChallenge(14),
                new AnotherChallenge(15),
                new AnotherChallenge(16),
                new AnotherChallenge(17),
                new AnotherChallenge(18),
                new AnotherChallenge(19),
                new AnotherChallenge(20),
                new AnotherChallenge(21),
                new AnotherChallenge(22),
                new AnotherChallenge(23),
                new AnotherChallenge(24),
                new AnotherChallenge(25),
                new AnotherChallenge(26),
                new AnotherChallenge(27),
                new AnotherChallenge(28),
                new AnotherChallenge(29),
                new AnotherChallenge(30),
                new AnotherChallenge(31),
                new AnotherChallenge(32),
                new AnotherChallenge(33),
            };
        }


    }
}
