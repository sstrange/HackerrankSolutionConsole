using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerrankSolutionConsole.Algorithms;

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
                //@@@ Algorithms @@@
                new a_very_big_sum(),
                new alternating_characters(),
                new anagram(),
                new angry_professor(),
                new beautiful_days_at_the_movies(),
                new between_two_sets(),
                new bigger_is_greater(),
                new camelcase(),
                new compare_the_triplets(),
                new cut_the_sticks(),
                new designer_pdf_viewer(),
                new divisible_sum_pairs(),
                new encryption(),
                new equality_in_a_array(),
                new fibonacci_modified(),
                new find_digits(),
                new flipping_bits(),
                new funny_string(),
                new game_of_stones_1(),
                new game_of_thrones(),
                new gem_stones(),
                new greedy_florist(),
                new gem_stones(),
                new grid_challenge(),
                new hackerland_radio_transmitters(),
                new icecream_parlor(),
                new insertionsort1(),
                new insertionsort2(),
                new jim_and_the_orders(),
                new jumping_on_the_clouds_revisited(),
                new jumping_on_the_clouds(),
                new kangaroo(),
                new lonely_integer(),
                new luck_balance(),
                new making_anagrams(),
                new mark_and_toys(),
                new mars_exploration(),
                new maximizing_xor(),
                new mini_max_sum(),
                new missing_numbers(),
                new pairs(),
                new pangrams(),
                new plus_minus(),
                new repeated_string(),
                new save_the_prisoner(),
                new sherlock_and_anagrams(),
                new sherlock_and_array(),
                new sherlock_and_the_beast(),
                new sherlock_and_valid_string(),
                new simple_array_sum(),
                new solve_me_first(),
                new staircase(),
                new strange_advertising(),
                new string_construction(),
                new sum_vs_xor(),
                new the_love_letter_mystery(),
                new time_conversion(),
                new tower_breakers_1(),
                new tutorial_intro(),
                new two_characters(),
                new utopian_tree(),




                //@@@ Fake @@@
                //new AnotherChallenge(1),
                //new AnotherChallenge(2),
                //new AnotherChallenge(3),
                //new AnotherChallenge(4),
                //new AnotherChallenge(5),
                //new AnotherChallenge(6),
                //new AnotherChallenge(7),
                //new AnotherChallenge(8),
                //new AnotherChallenge(9),
                //new AnotherChallenge(10),
                //new AnotherChallenge(11),
                //new AnotherChallenge(12),
                //new AnotherChallenge(13),
                //new AnotherChallenge(14),
                //new AnotherChallenge(15),
                //new AnotherChallenge(16),
                //new AnotherChallenge(17),
                //new AnotherChallenge(18),
                //new AnotherChallenge(19),
                //new AnotherChallenge(20),
                //new AnotherChallenge(21),
                //new AnotherChallenge(22),
                //new AnotherChallenge(23),
                //new AnotherChallenge(24),
                //new AnotherChallenge(25),
                //new AnotherChallenge(26),
                //new AnotherChallenge(27),
                //new AnotherChallenge(28),
                //new AnotherChallenge(29),
                //new AnotherChallenge(30),
                //new AnotherChallenge(31),
                //new AnotherChallenge(32),
                //new AnotherChallenge(33),
            };
        }


    }
}
