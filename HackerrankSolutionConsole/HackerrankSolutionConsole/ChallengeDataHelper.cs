using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    public class ChallengeDataHelper 
    {
        private List<Challenge> ChallengeList;
        
        public ChallengeDataHelper()
        {
            ChallengeList = BuildChallengeList();
        }

        public List<Challenge> GetAlgorithms()
        {
            return ChallengeList.Where(c => c.Domain == Domain.Algorithms).ToList();
        }

        public List<Challenge> GetArtificialIntelligence()
        {
            return ChallengeList.Where(c => c.Domain == Domain.ArtificialIntelligence).ToList();
        }

        public List<Challenge> GetDataStructures()
        {
            return ChallengeList.Where(c => c.Domain == Domain.DataStructures).ToList();
        }

        public List<Challenge> GetFunctionalProgramming()
        {
            return ChallengeList.Where(c => c.Domain == Domain.FunctionalProgramming).ToList();
        }

        public List<Challenge> GetMathematics()
        {
            return ChallengeList.Where(c => c.Domain == Domain.Mathematics).ToList();
        }

        public List<Challenge> GetEasy()
        {
            return ChallengeList.Where(c => c.Difficulty == Difficulty.Easy).ToList();
        }

        public List<Challenge> GetMedium()
        {
            return ChallengeList.Where(c => c.Difficulty == Difficulty.Medium).ToList();
        }

        public List<Challenge> GetHard()
        {
            return ChallengeList.Where(c => c.Difficulty == Difficulty.Hard).ToList();
        }

        private List<Challenge> BuildChallengeList()
        {
            return new List<Challenge>
            {
                new MiniMaxSum(),
                new AnotherChallenge(),
            };
        }


    }
}
