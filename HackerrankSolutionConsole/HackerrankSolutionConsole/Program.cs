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
        const int screenSizeX   = 74; //horizontal chars
        const int screenSizeY   = 24; //vertical lines
        const int mainMenuCode  = 1000000;
        const int exitCode      = 1000001;
        const int nextPageCode  = 1000003;
        const int prevPageCode  = 1000004;

        static void Main(string[] args)
        {
            ChallengeDataHelper challenges = new HackerrankSolutionConsole.ChallengeDataHelper();
            List<string> mainMenuOptions = new List<string>
            {
                "1.  List challenges by HackerRank domain (category)",
                "2.  List challenges by difficulty rating",
                "3.  Search challenges",
                "4.  Exit"
            };

            int menuChoice;
            do
            {
                menuChoice = DisplayMenu(mainMenuOptions);
                switch (menuChoice)
                {
                    case 1:
                        menuChoice = ListByDomain(challenges);
                        break;
                    case 2:
                        ListByDifficulty(challenges);
                        break;
                    case 3:
                        //Search();
                        break;
                }
            }
            while (menuChoice != 4 && menuChoice != exitCode);
        }

        static int ListByDomain(ChallengeDataHelper challenges)
        {
            List<string> domainOptions = new List<string>
            {
                "1.  Algorithms",
                "2.  Data Structures",
                "3.  Mathematics",
                "4.  Artificial Intelligence",
                "5.  Functional Programming",
                "6.  Back",
                "7.  Main Menu"
            };
            int menuChoice;
            do
            {
                menuChoice = DisplayMenu(domainOptions);
                switch (menuChoice)
                {
                    case 1:
                        //Algorithms
                        //Using linq build list of Challenge objects that are algorithms
                        //Pass that to DisplayChallenges() which is like DisplayMenu() but lists other info and has paging
                        //In DisplaChallenges() the user selects a specific Challenge object (by list index), and it passes that to ChallengeMenu() which will have the Run, url options
                        //ChallengeDataHelper cdh = new HackerrankSolutionConsole.ChallengeDataHelper();
                        //foreach (Challenge c in cdh.ChallengeList)
                        //{
                        //    Console.WriteLine(c.Name);
                        //    c.Main(new string[] { });
                        //}
                        menuChoice = DisplayChallenges(challenges.GetAlgorithms());
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }
            }
            while (menuChoice != 6 && menuChoice != 7 && menuChoice != mainMenuCode && menuChoice != exitCode);
            return menuChoice;
        }

        static void ListByDifficulty(ChallengeDataHelper challenges)
        {
            List<string> domainOptions = new List<string>
            {
                "1.  Easy",
                "2.  Medium",
                "3.  Hard",
                "4.  Back"
            };
            int menuChoice;
            do
            {
                menuChoice = DisplayMenu(domainOptions);
                switch (menuChoice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                }
            }
            while (menuChoice != 4);
        }

        static int DisplayMenu(List<string> menuOptions)
        {
            Console.Clear();

            //header (1 line)
            Console.WriteLine();

            //menu items
            foreach (string mo in menuOptions)
                Console.WriteLine(mo);
            for (int i = 0; i < screenSizeY - menuOptions.Count - 5; i++)
                Console.WriteLine();

            //footer (4 lines)
            Console.WriteLine(new string('-', screenSizeX));
            Console.WriteLine("   b: back       m: main menu");
            Console.WriteLine(new string('-', screenSizeX));
            Console.Write("Enter Selection (1 - {0}):", menuOptions.Count);
            string input = Console.ReadLine();
            int result;
            int.TryParse(input, out result);
            if (result >= 1 && result <= menuOptions.Count)
                return result;
            
            return DisplayMenu(menuOptions);
        }

        static int DisplayChallenges(List<Challenge> challenges)
        {
            //todo: back
            //todo: paging
            //todo: none listed
            int menuItems = challenges.Count;
            Console.Clear();

            //header (3 lines)
            Console.WriteLine();
            Console.WriteLine(BuildChallengeLine("", "Challenge","Domain","Difficulty"));
            Console.WriteLine(new string('-', screenSizeX));

            for(int i = 1; i <= challenges.Count; i++)
            {
                Challenge c = challenges[i-1];
                Console.WriteLine(BuildChallengeLine(i+".", c.Name, c.Domain.ToString(), c.Difficulty.ToString()));
            }
            Console.WriteLine(BuildChallengeLine((++menuItems) + ".", "Back", "", ""));
            //Console.WriteLine(BuildChallengeLine((++menuItems).ToString() + ".", "Main Menu", "", ""));
            

            for (int i = 0; i < screenSizeY - menuItems - 3; i++)
                Console.WriteLine();
            Console.Write("Enter Selection (1 - {0}):", menuItems);
            string input = Console.ReadLine();
            int result;
            int.TryParse(input, out result);
            if (result == 9)
                return mainMenuCode;
            if (result == 10)
                return exitCode;
            if (result >= 1 && result <= menuItems)
                return result;

            return DisplayChallenges(challenges);
        }

        static string BuildChallengeLine(string numberColumnText, string nameColumnText, string domainColumnText, string difficultyColumnText)
        {
            int numberColumnSize = 4;
            int nameColumnSize = Convert.ToInt16((screenSizeX-numberColumnSize) * .51); //50;
            int domainColunmSize = Convert.ToInt16((screenSizeX - numberColumnSize) * .33); //30;
            int difficultyColumnSize = Convert.ToInt16((screenSizeX - numberColumnSize) * .16); //10;

            string line = numberColumnText.PadRight(numberColumnSize).Substring(0, numberColumnSize); 
            line += nameColumnText.PadRight(nameColumnSize).Substring(0, nameColumnSize);
            line += domainColumnText.PadRight(domainColunmSize).Substring(0, domainColunmSize);
            line += difficultyColumnText.PadRight(difficultyColumnSize).Substring(0, difficultyColumnSize);
            return line;
        }

        //static int GetInput(int menuSize)
        //{
        //    for (int i = 0; i < maxMenuSize - menuSize -1; i++)
        //        Console.WriteLine();
        //    Console.Write(string.Format("Enter Selection (1 - {0}):", menuSize));
        //    string input = Console.ReadLine();
        //    int result;
        //    int.TryParse(input, out result); 
        //    if (result >= 1 && result <= menuSize)
        //        return result;
        //    else
        //        return 0;
        //}

        //static int DisplayMainMenu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("1. List by HackerRank domain (category)");
        //    Console.WriteLine("2. List by difficulty rating");
        //    Console.WriteLine("3. Search");
        //    Console.WriteLine("4. Exit");
        //    int input = GetInput(4);
        //    if (input == 0)
        //        return DisplayMainMenu();
        //    else
        //        return input;
        //}

        //static void DisplaySolutionMenu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("1. Open challenge description on HackerRank.Com");
        //    Console.WriteLine("2. Run");
        //    Console.WriteLine("3. Back");
        //}
        //static void DisplayDomainMenu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("1. Algorithms");
        //    Console.WriteLine("2. Data Structures");
        //    Console.WriteLine("3. Mathematics");
        //    Console.WriteLine("4. Artificial Intelligence");
        //    Console.WriteLine("5. Functional Programming");
        //    Console.WriteLine("6. Back");
        //}
        //static void DisplayDifficultyMenu()
        //{
        //    Console.Clear();
        //    Console.WriteLine("1. Easy");
        //    Console.WriteLine("2. Medium");
        //    Console.WriteLine("3. Hard");
        //    Console.WriteLine("4. Back");
        //}
    }


    
}
