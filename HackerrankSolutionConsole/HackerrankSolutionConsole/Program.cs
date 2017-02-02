using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    
    //public delegate void SolutionDelegate(string[] args);

    class Solution
    {
        const int screenSizeX           = 74; //horizontal chars
        const int screenSizeY           = 24; //vertical lines
        const int headerFooterSize      = 7; //7 = 3 lines in header + 4 lines in footer
        const int numberColumnSize      = 5; //used for indenting 
        const string hackerRankPath      = "www.hackerrank.com/challenges/";


        static void Main(string[] args)
        {
            ChallengeDataHelper challenges = new HackerrankSolutionConsole.ChallengeDataHelper();
            MainMenu(challenges);
        }

        static void MainMenu(ChallengeDataHelper challenges)
        {
            List<string> mainMenuOptions = new List<string>
            {
                " 1.  List all challenges",
                " 2.  List challenges by HackerRank domain (category)",
                " 3.  List challenges by difficulty rating",
                " 4.  Search challenges"
            };

            List<string> footerOptions = new List<string> { "e" };

            string menuChoice;
            do
            {
                menuChoice = DisplayMenu(mainMenuOptions, footerOptions, "    Main Menu");
                switch (menuChoice)
                {
                    case "1":
                        menuChoice = ChallengesMenu(challenges.GetAllChallenges());
                        break;
                    case "2":
                        menuChoice = DomainMenu(challenges);
                        break;
                    case "3":
                        menuChoice = DifficultyMenu(challenges);
                        break;
                    case "4":
                        menuChoice = SearchMenu(challenges);
                        break;
                }
            }
            while (!footerOptions.Contains(menuChoice));
        }


        static string DomainMenu(ChallengeDataHelper challenges)
        {
            var domainOptions = new List<string>
            {
                " 1.  Algorithms",
                " 2.  Data Structures",
                " 3.  Mathematics",
                " 4.  Artificial Intelligence",
                " 5.  Functional Programming"
            };

            List<string> footerOptions = new List<string> { "e","b","m" };

            string menuChoice;
            do
            {
                menuChoice = DisplayMenu(domainOptions, footerOptions, "    Domains");
                switch (menuChoice)
                {
                    case "1":
                        menuChoice = ChallengesMenu(challenges.GetAlgorithms()).Replace("b"," ");
                        break;
                    case "2":
                        menuChoice = ChallengesMenu(challenges.GetDataStructures()).Replace("b", " ");
                        break;
                    case "3":
                        menuChoice = ChallengesMenu(challenges.GetMathematics()).Replace("b", " ");
                        break;
                    case "4":
                        menuChoice = ChallengesMenu(challenges.GetArtificialIntelligence()).Replace("b", " ");
                        break;
                    case "5":
                        menuChoice = ChallengesMenu(challenges.GetFunctionalProgramming()).Replace("b", " ");
                        break;
                }
            }
            while (!footerOptions.Contains(menuChoice));
            return menuChoice;
        }

        static string DifficultyMenu(ChallengeDataHelper challenges)
        {
            var domainOptions = new List<string>
            {
                " 1.  Easy",
                " 2.  Medium",
                " 3.  Hard"
            };

            List<string> footerOptions = new List<string> { "e", "b", "m" };

            string menuChoice;
            do
            {
                menuChoice = DisplayMenu(domainOptions, footerOptions, "    Difficulty");
                switch (menuChoice)
                {
                    case "1":
                        menuChoice = ChallengesMenu(challenges.GetEasy()).Replace("b", " ");
                        break;
                    case "2":
                        menuChoice = ChallengesMenu(challenges.GetMedium()).Replace("b", " ");
                        break;
                    case "3":
                        menuChoice = ChallengesMenu(challenges.GetHard()).Replace("b", " ");
                        break;
                }
            }
            while (!footerOptions.Contains(menuChoice));
            return menuChoice;
        }

        static string ChallengesMenu(List<Challenge> challenges)
        {  
            var footerOptions = new List<string> { "e", "b", "m" };
            string menuChoice;
            do
            {
                menuChoice = DisplayMenu(challenges, footerOptions);    //menuChoice validated in DisplayMenu(). now contains a valid value
                if (!footerOptions.Contains(menuChoice))
                {
                    int index;
                    int.TryParse(menuChoice, out index);
                    menuChoice = ChallengeSelectedMenu(challenges[--index]).Replace("b", "");
                }
            }
            while (!footerOptions.Contains(menuChoice));
            return menuChoice;
        }

        static string SearchMenu(ChallengeDataHelper challenges)
        {   
            var footerOptions = new List<string> { "e", "b", "m" };
            string menuChoice;
            do
            {
                string searchString;
                do
                {
                    Console.Clear();

                    //Header
                    PrintHeader(BuildChallengeLine("", "Challenge", "Domain", "Subdomain", "Difficulty"));

                    //Nothing listed at this point
                    for (int i = 0; i < screenSizeY - headerFooterSize; i++)
                        Console.WriteLine();

                    //Footer
                    string prompt = " Search for: ";
                    Console.WriteLine(new string('-', screenSizeX));
                    Console.WriteLine();
                    Console.WriteLine(new string('-', screenSizeX));
                    Console.Write(prompt);

                    //Input
                    searchString = Console.ReadLine().ToLower().Trim();
                }
                while (string.IsNullOrEmpty(searchString));
                menuChoice = ChallengesMenu(challenges.Search(searchString)).Replace("b", "");
            }
            while (!footerOptions.Contains(menuChoice));
            return menuChoice;
        }

        static string ChallengeSelectedMenu(Challenge challenge)
        {
            var domainOptions = new List<string>
            {
                " 1.  Open challege description in hackerrank.com",
                " 2.  Run solution"
            };

            var footerOptions = new List<string> { "e", "b", "m" };
            
            string menuChoice;
            do
            {
                menuChoice = DisplayMenu(domainOptions, footerOptions, "    " + challenge.Name);
                switch (menuChoice)
                {
                    case "1":
                        System.Diagnostics.Process.Start(hackerRankPath + challenge.Path);
                        break;
                    case "2":
                        Console.Clear();
                        challenge.Main(new string[] {});
                        Console.WriteLine("Press any key to return to the console.");
                        Console.ReadLine();
                        break;
                }
            }
            while (!footerOptions.Contains(menuChoice));
            return menuChoice;
        }

        static string DisplayMenu(List<string> menuOptions, List<string> footerOptions, string header)
        {
            Console.Clear();

            //Header
            PrintHeader(header);

            //Menu options
            foreach (string mo in menuOptions)
                Console.WriteLine(mo);
            for (int i = 0; i < screenSizeY - menuOptions.Count - headerFooterSize; i++)       
                Console.WriteLine();

            //Footer
            PrintFooter(1, menuOptions.Count, footerOptions);

            //Input
            string input = Console.ReadLine().ToLower().Trim();
            if (ValidateInput(input, 1, menuOptions.Count, footerOptions))
                return input;
            
            return DisplayMenu(menuOptions, footerOptions, header);
        }

        static string DisplayMenu(List<Challenge> challenges, List<string> footerOptions, int page = 1)
        {
            Console.Clear();

            //Header
            PrintHeader(BuildChallengeLine("", "Challenge", "Domain", "Subdomain", "Difficulty"));

            //Challenge list
            int pageSize = screenSizeY - headerFooterSize;
            int first = (page -1) * pageSize +1;
            int last = challenges.Count > (pageSize * page) ? pageSize * page : challenges.Count;
            for (int i = 1; i <= challenges.Count; i++)
            {
                if (i >= first && i <= last)
                {
                    Challenge c = challenges[i - 1];
                    Console.WriteLine(BuildChallengeLine(i + ".", c.Name, c.Domain.ToString(), c.Subdomain.ToString(), c.Difficulty.ToString()));
                }
            }
            for (int i = 0; i < screenSizeY - (last - first +1) - headerFooterSize; i++)       
                Console.WriteLine();
            
            //Footer
            List<string> footerOptionsWithPaging = new List<string>(footerOptions);
            if(first > 1)
                footerOptionsWithPaging.Add("p");
            if(last < challenges.Count)
                footerOptionsWithPaging.Add("n");
            PrintFooter(first, last, footerOptionsWithPaging);

            //Input
            string input = Console.ReadLine().ToLower().Trim();
            if (!ValidateInput(input, first, last, footerOptionsWithPaging))
                return DisplayMenu(challenges, footerOptions, page);
            if (input == "p")
                return DisplayMenu(challenges, footerOptions, page - 1);
            if (input == "n")
                return DisplayMenu(challenges, footerOptions, page + 1);
            return input;
        }

        static bool ValidateInput(string input, int first, int last, List<string> footerOptions)
        {
            if (footerOptions.Contains(input))
                return true; 
            int result;
            if (int.TryParse(input, out result))
                return (result >= first && result <= last);
            return false;
        }

        static void PrintFooter(int first, int last, List<string> footerOptions)
        { 
            string footerLine = "";
           
            if (footerOptions.Contains("e"))
                footerLine += "   e: exit";
            else
                footerLine += "          ";
            if (footerOptions.Contains("b"))
                footerLine += "   b: back";
            else
                footerLine += "          ";
            if (footerOptions.Contains("m"))
                footerLine += "   m: main menu";
            else
                footerLine += "               ";
            if (footerOptions.Contains("p"))
                footerLine += "   p: prev page";
            else
                footerLine += "               ";
            if (footerOptions.Contains("n"))
                footerLine += "   n: next page";
            else
                footerLine += "               ";
           
            //string prompt = string.Format("Enter Selection ({0}-{1}, {2}): ", first, last, string.Join(", ", footerOptions));
            string prompt = " Enter Selection: ";
            Console.WriteLine(new string('-', screenSizeX));
            Console.WriteLine(footerLine);
            Console.WriteLine(new string('-', screenSizeX));
            Console.Write(prompt);
        }

        static void PrintHeader(string header)
        {
            Console.WriteLine();
            Console.WriteLine(header);
            Console.WriteLine(new string('-', screenSizeX));
        }


        static string BuildChallengeLine(string numberColumnText, string nameColumnText, string domainColumnText, string subdomainColumnText, string difficultyColumnText)
        {
            int numberColumnSize = 5;
            int nameColumnSize = Convert.ToInt16((screenSizeX - numberColumnSize) * .36);
            int domainColunmSize = Convert.ToInt16((screenSizeX - numberColumnSize) * .24);
            int subdomainColumnSize = Convert.ToInt16((screenSizeX - numberColumnSize) * .24);
            int difficultyColumnSize = Convert.ToInt16((screenSizeX - numberColumnSize) * .16);

            numberColumnText = " " + numberColumnText;
            string line = numberColumnText.PadRight(numberColumnSize).Substring(0, numberColumnSize);
            line += nameColumnText.PadRight(nameColumnSize).Substring(0, nameColumnSize);
            line += domainColumnText.PadRight(domainColunmSize).Substring(0, domainColunmSize);
            line += subdomainColumnText.PadRight(subdomainColumnSize).Substring(0, subdomainColumnSize);
            line += difficultyColumnText.PadRight(difficultyColumnSize).Substring(0, difficultyColumnSize);
            return line;
        }
    }
}
