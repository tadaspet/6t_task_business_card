using System.Diagnostics.CodeAnalysis;

namespace _17.Projektas
{
    public class Projektas_ProtMusis
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users;
            IOrderedEnumerable<KeyValuePair<string, int>> sortedScores;
            string currentUser;
            int menuSelection = 0;
            bool quit = false;
            string category;
            FirstUser(out users, out currentUser);
            do
            {
                MenuSelection(currentUser, out menuSelection);
                switch (menuSelection)
                {
                    case 1:
                        {
                            do 
                            {
                                QuizSubMenu(currentUser, users, quit);
                                RepeatQuizSubMenu(currentUser, out quit);
                            }while (!quit);
                            break;
                        }
                    case 2:
                        {
                            Rules(currentUser);
                            break;
                        }
                    case 3:
                        {
                            do
                            {
                                ResultsSubMenu(currentUser, users, quit);
                                RepeatResultsSubMenu(currentUser, out quit);
                            }while (!quit);
                            break;
                        }
                    case 4:
                        {
                            NewUser(users, ref currentUser);
                            break;
                        }
                    case 5:
                        {
                            CloseQuizGame();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (menuSelection > 0 && menuSelection < 5);
        }
        #region Register
        public static void FirstUser(out Dictionary<string, Dictionary<string, int>> usersBook, out string currentUser)
        {
            Console.WriteLine("Hello, welcome to the Geography Quiz Game!");
            usersBook = new Dictionary<string, Dictionary<string,int>>();
            Console.WriteLine("Please register in the system by Name and Surname:");
            currentUser = Console.ReadLine();
            Console.WriteLine("Registration was succesfull!");
            usersBook.Add(currentUser, new Dictionary<string,int>());
            CategoryKeys(usersBook);
            Thread.Sleep(1000);
            Console.Clear();
        }
        public static void NewUser(Dictionary<string, Dictionary<string, int>> users, ref string currentUser)
        {
            Console.WriteLine(value: $"Current player - {currentUser}.\n");
            Console.WriteLine("Please enter new Name and Surname:");
            currentUser = Console.ReadLine();
            bool check = users.ContainsKey(currentUser);
            string check2;
            string newUser2;
            if (check)
            {
                Console.WriteLine("This user is in use, would like to create new user?\nYes/No");
                check2 = Console.ReadLine().ToLower();
                if (check2 == "yes")
                {
                    Console.WriteLine("Please eneter your Name and Surname:");
                    newUser2 = Console.ReadLine();
                    users.Add(newUser2, new Dictionary<string, int>());
                    currentUser = newUser2;
                }
                else
                {
                    Console.WriteLine($"Current user {currentUser} results will be changed.");
                }
            }
            else
            {
                Console.WriteLine("You have been registered successfully!");
                users.Add(currentUser, new Dictionary<string, int>());
            }
            Thread.Sleep(2000);
            Console.Clear();
            CategoryKeys(users);
        }
        public static void CategoryKeys(Dictionary<string, Dictionary<string, int>> users)
        {
            List<string> allCategories = new List<string> { "Cities", "Lakes", "Mountains" };
            foreach (var user in users)
            {
                foreach (var category in allCategories)
                {
                    if (!user.Value.ContainsKey(category))
                        user.Value[category] = 0;
                }
            }
        }
        #endregion

        #region Menu
        public static void ActionMenu (out int menuSelection)
        {
            string menuInput = Console.ReadLine();
            menuSelection = 0;
            int menuOption;
            bool menuCheck = int.TryParse(menuInput, out menuOption);
            bool invalidSelection = menuOption > 5 || menuOption < 1;
            while (invalidSelection)
            {
                Console.WriteLine("Please re-enter valid number from menu:");
                string secondTry = Console.ReadLine();
                if (int.TryParse(secondTry, out menuOption))
                {
                    menuSelection = menuOption;
                    invalidSelection = menuOption > 5 || menuOption < 1;
                }
                else if (secondTry == "q" || secondTry == "Q")
                {
                    invalidSelection = false;
                    Console.WriteLine("Rules will be opened");
                    menuSelection = 2;  
                }
            }
            if (menuOption < 6 && menuOption > 0 && menuInput != "q")
            {
                switch (menuOption)
                {
                    case 1:
                        menuSelection = 1;
                        Console.WriteLine("Starting the GAME!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    case 2:
                        menuSelection = 2;
                        Console.WriteLine("Opening the RULES.");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    case 3:
                        menuSelection = 3;
                        Console.WriteLine("Opening the PLAYER RECORDS.");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    case 4:
                        menuSelection = 4;
                        Console.WriteLine("Opening the CHANGE PLAYER");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    case 5:
                        menuSelection = 5;
                        Console.WriteLine("I hope see you soon, QUITING GAME");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Try another menu option:");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }
            if (!menuCheck)
            {
                Console.WriteLine("Invalid menu character.\nPlease enter 2 to read the rules.");
            }
        }
        public static void MenuSelection(string currentUser, out int menuSelection)
        {
            Console.Clear();
            Console.WriteLine($"Current player - {currentUser}.\n");
            Console.WriteLine("CHOOSE MENU ACTION BY NUMBER:");
            Dictionary<int, string> menu = new Dictionary<int, string>()
            {   {1, "Start Game" },
                {2, "Rules" },
                {3, "Player Records" },
                {4, "Change Player" },
                {5, "Quit Game" }
            };
            foreach(var optionKeyValuePair in menu)
            {
                Console.WriteLine(optionKeyValuePair.Key + ". " + optionKeyValuePair.Value);
            }
            ActionMenu(out menuSelection);
        }
        public static void Rules(string currentUser)
        {
            Console.WriteLine($"Current player - {currentUser}.\n");
            Console.WriteLine("Navigation:" +
                "\n\t- Quiz game is navigated by entering number of the possible menu option;" +
                "\n\t- Enter 'q' to go back from to the main menu from:" +
                "\n\t\t1.Start Game," +
                "\n\t\t2.Rules," +
                "\n\t\t3.Player Records.\n" +
                "\nChange Player:" +
                "\n\t- Enter new Name and Surname to save your results as different player;" +
                "\n\t- If player name was taken you can choose to overwrite his results, after additional confirmation.\n" +
                "\nStatistics:" +
                "\n\t- All results are displayed by decending order from the best to lowest score;" +
                "\n\t- When score results are equal earlier result is shown above later;" +
                "\n\t- After each Quiz you can see category score records;" +
                "\n\t- Menu 3. Player Records:" +
                "\n\t\t1.Top Results - player ranks by overall score;" +
                "\n\t\t2.Detailed results - all player with separate category scores.");
            bool quit;
            MenuBackToPrevious(out quit);
        }
        public static void MenuBackToPrevious(out bool quit)
        {
            Console.WriteLine("\nPlease enter 'q' to go back.");
            string inPut = Console.ReadLine();
            while(inPut != "q")
            {
                Console.WriteLine("Please enter 'q' to go back.");
                inPut = Console.ReadLine();
            }
            quit = true;
            Console.Clear();
        }
        public static void RepeatQuizSubMenu(string currentUser, out bool quit)
        {
            Console.Clear ();
            Console.WriteLine($"Current player - {currentUser}.\n");
            Console.WriteLine("Press - Enter to choose quizes\nPress - 'q' to go back to main menu:");
            string check = Console.ReadLine();
            if (check == "q")
            {
                quit = true;
            }
            else 
            {
                quit = false;
            }
            Console.Clear();
        }

        #endregion

        #region Quizes
        public static void QuizSubMenu(string currentUser, Dictionary<string, Dictionary<string, int>> users, bool quit)
        {
            string category;
            quit = false;
            int menuOption = -1;
            Console.WriteLine($"Current player - {currentUser}.\n");
            Console.WriteLine("1.Cities\n2.Lakes\n3.Mountains");
            string subInput = Console.ReadLine();
            bool menuCheck = int.TryParse(subInput, out menuOption);
            if (subInput == "q" && !menuCheck)
            {
                quit = true;
            }
            while ((menuOption > 3 || menuOption < 1) && !quit)
            {
                Console.WriteLine("Please re-enter valid number from menu:");
                string secondTry = Console.ReadLine();
                bool check = int.TryParse(secondTry, out menuOption);
                menuCheck = check;
                if (secondTry == "q")
                {
                    Console.WriteLine("Returning...");
                    quit = true;
                    break;
                }
            }
            while (menuOption < 4 && menuOption > 0 && !quit)
            {
                switch (menuOption)
                {
                    case 1:
                        category = "Cities";
                        CapitalPopulation2023(currentUser, users, category, out quit);
                        Console.Clear();
                        break;
                    case 2:
                        category = "Lakes";
                        LargestsLakesOfContinents(currentUser, users, category, out quit);
                        Console.Clear();
                        break;
                    case 3:
                        category = "Mountain";
                        MountainCountries(currentUser, users, category, out quit);
                        Console.Clear();
                        break;
                    default:
                        break;
                } 
            } 
        }
        public static void BackToQuizResults(out bool quit, string category)
        {
            Console.WriteLine($"\nPlease enter 'q' to view {category} all players scores.");
            string inPut = Console.ReadLine();
            while (inPut != "q")
            {
                Console.WriteLine("Please enter 'q' to return.");
                inPut = Console.ReadLine();
            }
            quit = true;
            Console.Clear();
        }
        public static void CapitalPopulation2023(string currentUser, Dictionary<string, Dictionary<string, int>> users, string category, out bool quit)
        {
            Dictionary<string, List<string>> cityPopulations = new Dictionary<string, List<string>>()
            {
                {"Berlin", new List<string> { "3.5 mln", "4.3 mln", "2.9 mln", "3.8 mln" } }, 
                {"Rome", new List<string> { "2.9 mln", "2.3 mln", "1.9 mln", "1.8 mln" } }, 
                {"Madrid", new List<string> { "4.9 mln", "1.3 mln", "2.9 mln", "3.8 mln" } }, 
                {"Vienna", new List<string> { "3.0 mln", "2.5 mln", "1.9 mln", "2.0 mln" } }, 
                {"London", new List<string> { "8.7 mln", "9.6 mln", "10.9 mln", "7.8 mln" } } 
            };
            List<int> answers = new List<int> { 2, 1, 3, 4, 2 };
            List<int> userAnsw = new List<int>();
            List<string> city = new List<string>(cityPopulations.Keys);
            int pointAmount = 0;
            quit = false;
            Thread.Sleep(1500);
            Console.Clear();
            for ( int i = 0; i < city.Count; i++)
            {
                List<string> populations = cityPopulations[city[i]];
                Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\nQuestion - {i+1}/5");
                Console.WriteLine($"What population is in the {city[i].ToUpper()} at 2023?");
                for(int j = 0; j < populations.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {populations[j]}");
                }
                Console.WriteLine("Type the answer number:");
                int userAnswer;
                string answerInput = Console.ReadLine();
                bool parseCheck= int.TryParse( answerInput, out userAnswer);
                if (answerInput == "q")
                {
                    quit = true;
                    break;
                }
                if (userAnswer == answers[i])
                {
                    Console.WriteLine("Answer is correct!");
                    pointAmount+=2;
                    userAnsw.Add(1);
                }
                else
                {
                    Console.WriteLine("Awnswer is wrong.");
                    userAnsw.Add(0);
                }
                Thread.Sleep(1500);
                Console.Clear();
            }
            users[currentUser][category] = pointAmount;
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            Console.WriteLine($"Category {category} summary.".PadLeft(35));
            for (int i = 0;i < userAnsw.Count;i++)
            {
                if (userAnsw[i] == 1)
                {
                    Console.Write($"No.{i+1} Correct".PadRight(15) + $"Points - 2\n");
                }
                else if (userAnsw[i] == 0)
                {
                    Console.Write($"No.{i + 1} Wrong".PadRight(15) + $"Points - 0\n");
                }
            }
            Console.WriteLine("".PadRight(9) + $"Total Points - {pointAmount}");
            BackToQuizResults(out quit, category);
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            ByCategoryResultsTable(users, category);
            MenuBackToPrevious(out quit);
        }
        public static void LargestsLakesOfContinents(string currentUser, Dictionary<string, Dictionary<string, int>> users, string category, out bool quit)
        {
   
            Dictionary<string, List<string>> contLakes = new Dictionary<string, List<string>>()
            {
                {"North America", new List<string> { "Lake Michigan", "Lake Huron", "Lake Superior", "Great Bear Lake" } }, 
                {"South America", new List<string> { "Lake Maracaibo", "Lake Buenos Aires", "Lake Nicaragua","Lake Titicaca" } }, 
                {"Europe", new List<string> { "Lake Ladoga", "Lake Onega", "Lake Vänern", "Lake Peipus" } }, 
                {"Asia", new List<string> { "Lake Baikal", "Aral Sea", "Caspian Sea", "Lake Balkhash" } }, 
                {"Africa", new List<string> { "Lake Tanganyika", "Lake Victoria", "Lake Malawi", "Lake Turkana" } } 
            };
            List<int> answers = new List<int> { 3, 4, 1, 3, 2 };
            List<int> userAnsw = new List<int>();
            List<string> continent = new List<string>(contLakes.Keys);
            int pointAmount = 0;
            quit = false;
            Thread.Sleep(1500);
            Console.Clear();
            for (int i = 0; i < continent.Count; i++)
            {
                List<string> lakeList = contLakes[continent[i]];
                Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\nQuestion - {i + 1}/5");
                Console.WriteLine($"What lake is the biggest in the {continent[i].ToUpper()} continent?");
                for (int j = 0; j < lakeList.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {lakeList[j]}");
                }
                Console.WriteLine("Type the answer number:");
                int userAnswer;
                string answerInput = Console.ReadLine();
                bool parseCheck = int.TryParse(answerInput, out userAnswer);
                if (answerInput == "q")
                {
                    quit = true;
                    break;
                }
                if (userAnswer == answers[i])
                {
                    Console.WriteLine("Answer is correct!");
                    pointAmount += 2;
                    userAnsw.Add(1);
                }
                else
                {
                    Console.WriteLine("Awnswer is wrong.");
                    userAnsw.Add(0);
                }
                Thread.Sleep(1500);
                Console.Clear();
            }
            users[currentUser][category] = pointAmount;
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            Console.WriteLine($"Category {category} summary.".PadLeft(35));
            for (int i = 0; i < userAnsw.Count; i++)
            {
                if (userAnsw[i] == 1)
                {
                    Console.Write($"No.{i + 1} Correct".PadRight(15) + $"Points - 2\n");
                }
                else if (userAnsw[i] == 0)
                {
                    Console.Write($"No.{i + 1} Wrong".PadRight(15) + $"Points - 0\n");
                }
            }
            Console.WriteLine("".PadRight(9) + $"Total Points - {pointAmount}");
            BackToQuizResults(out quit, category);
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            ByCategoryResultsTable(users, category);
            MenuBackToPrevious(out quit);
        }
        public static void MountainCountries(string currentUser, Dictionary<string, Dictionary<string, int>> users, string category, out bool quit)
        {
            Dictionary<string, List<string>> countryMountain = new Dictionary<string, List<string>>()
            {
                {"Bhutan", new List<string> { "95.0%", "98.8%", "90.7%", "85.2%" } },
                {"Nepal", new List<string> { "75.6%", "70.4%", "87.7%", "65.5%" } },
                {"Tajikistan", new List<string> { "85.9%", "80.5%", "75.7%", "91.9%" } },
                {"Kyrgyzstan", new List<string> { "85.3%", "90.7%", "80.7%", "75.6%" } },
                {"China", new List<string> { "70%", "65.2%", "60.7%", "55.5%" } }
            };
            List<int> answers = new List<int> { 2, 3, 4, 2, 1 };
            List<int> userAnsw = new List<int>();
            List<string> country = new List<string>(countryMountain.Keys);
            int pointAmount = 0;
            Thread.Sleep(1500);
            Console.Clear();
            for (int i = 0; i < country.Count; i++)
            {
                List<string> percMountain = countryMountain[country[i]];
                Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\nQuestion - {i + 1}/5");
                Console.WriteLine($"What percentage of {country[i].ToUpper()}'s total area is covered in mountains?");
                for (int j = 0; j < percMountain.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {percMountain[j]}");
                }
                Console.WriteLine("Type the answer number:");
                int userAnswer;
                string answerInput = Console.ReadLine();
                bool parseCheck = int.TryParse(answerInput, out userAnswer);
                if (answerInput == "q")
                {
                    quit = true;
                    break;
                }
                if (userAnswer == answers[i])
                {
                    Console.WriteLine("Answer is correct!");
                    pointAmount += 2;
                    userAnsw.Add(1);
                }
                else
                {
                    Console.WriteLine("Awnswer is wrong.");
                    userAnsw.Add(0);
                }
                Thread.Sleep(1500);
                Console.Clear();
            }
            users[currentUser][category] = pointAmount;
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            Console.WriteLine($"Category {category} summary.".PadLeft(35));
            for (int i = 0; i < userAnsw.Count; i++)
            {
                if (userAnsw[i] == 1)
                {
                    Console.Write($"No.{i + 1} Correct".PadRight(15) + $"Points - 2\n");
                }
                else if (userAnsw[i] == 0)
                {
                    Console.Write($"No.{i + 1} Wrong".PadRight(15) + $"Points - 0\n");
                }
            }
            Console.WriteLine("".PadRight(9) + $"Total Points - {pointAmount}");
            BackToQuizResults(out quit, category);
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            ByCategoryResultsTable(users, category);
            MenuBackToPrevious(out quit);
        }
        #endregion

        #region Player Records
        public static void ByCategoryResultsTable(Dictionary<string, Dictionary<string, int>> users, string category)
        {
            Dictionary<string, Dictionary<string, int>> totalTable = new Dictionary<string, Dictionary<string, int>>();
            foreach (var user in users)
            {
                int sum = 0;

                foreach (var results in user.Value)
                {
                    sum += results.Value;
                }
                var replacement = new Dictionary<string, int>(user.Value);
                replacement["Total"] = sum;
                totalTable[user.Key] = replacement;
            }
            var sortedUserstotalTable = totalTable.OrderByDescending(user => user.Value[category]);
            int count = 1;
            Console.WriteLine($"Players Scores in category - {category}:\n");
            foreach (var user in sortedUserstotalTable)
            {
                foreach (var result in user.Value)
                {
                    if (result.Key == category)
                    {
                        Console.WriteLine($"No.{count} {user.Key}\t\t{result.Value}");
                    }
                }
                count++;
            } 

        }
        public static void TotalCategoryResultsTable(Dictionary<string, Dictionary<string, int>> users)
        {
            Dictionary<string, Dictionary<string, int>> totalTable = new Dictionary<string, Dictionary<string, int>>();
            foreach (var user in users)
            {
                int sum = 0;

                foreach (var results in user.Value)
                {
                    sum += results.Value;
                }
                var replacement = new Dictionary<string, int>(user.Value);
                replacement["Total"] = sum;
                totalTable[user.Key] = replacement;
            }
            var sortedUserstotalTable = totalTable.OrderByDescending(user => user.Value["Total"]);
            int count = 1;
            foreach (var user in sortedUserstotalTable)
            {

                Console.WriteLine($"No.{count} {user.Key}");
                foreach (var result in user.Value)
                {
                    Console.Write($"\t{result.Key.PadRight(20)}");
                }
                Console.WriteLine();
                foreach (var result in user.Value)
                {
                    Console.Write($"\t{result.Value.ToString().PadRight(20)}");
                }
                Console.WriteLine();
                count++;
            }
        }
        public static void CalculatedAndSorted(Dictionary<string, Dictionary<string, int>> users, out IOrderedEnumerable<KeyValuePair<string,int>> sortedScores)
        {
            Dictionary<string, int>  totals = new Dictionary<string, int>();
            foreach (var user in users)
            {
                int sum = 0;
                foreach (var results in user.Value)
                {
                    if (results.Key == "Totals")
                    {
                        continue;
                    }
                    sum += results.Value;
                }
                totals[user.Key] = sum;
            }
            sortedScores = totals.OrderByDescending(sum => sum.Value);
        }
        public static void PrintSortedScores(Dictionary<string, Dictionary<string, int>> users)
        {
            CalculatedAndSorted(users, out var sortedScores);

            int count = 0;
            foreach (var user in sortedScores)
            {
                string additionalChars = "";
                if (count == 0)
                {
                    additionalChars = "***";
                }
                else if (count == 1)
                {
                    additionalChars = "**";
                }
                else if (count == 2)
                {
                    additionalChars = "*";
                } 
                Console.WriteLine($"No{count+1}. {user.Key}{additionalChars} - {user.Value}");
                count++;
            }
        }
        public static void ResultsSubMenu(string currentUser, Dictionary<string, Dictionary<string, int>> users, bool quit)
        {
            Console.Clear();
            string resultsType;
            quit = false;
            int menuOption = -1;
            Console.WriteLine($"Current player - {currentUser}.\n");
            Console.WriteLine("1.Top Results\n2.Detailed results");
            string subInput = Console.ReadLine();
            bool menuCheck = int.TryParse(subInput, out menuOption);
            if (subInput == "q" && !menuCheck)
            {
                quit = true;
            }
            while ((menuOption > 2 || menuOption < 1) && !quit)
            {
                Console.WriteLine("Please re-enter valid number from menu:");
                string secondTry = Console.ReadLine();
                bool check = int.TryParse(secondTry, out menuOption);
                menuCheck = check;
                if (secondTry == "q")
                {
                    Console.WriteLine("Returning...");
                    quit = true;
                    break;
                }
            }
            while (menuOption < 3 && menuOption > 0 && !quit)
            {
                switch (menuOption)
                {
                    case 1:
                        PrintSortedScores(users);
                        Console.Clear();
                        break;
                    case 2:
                        TotalCategoryResultsTable(users);
                        Console.Clear();
                        break;
                    default:
                        break;
                }


            }
        }
        public static void RepeatResultsSubMenu(string currentUser, out bool quit)
        {
            Console.Clear();
            Console.WriteLine($"Current player - {currentUser}.\n");
            Console.WriteLine("Press - Enter to choose Results\nPress - 'q' to go back to main menu:");
            string check = Console.ReadLine();
            if (check == "q")
            {
                quit = true;
            }
            else
            {
                quit = false;
            }
            Console.Clear();
        }
        #endregion

        public static void CloseQuizGame()
        {
            string goodBey = "Good Bey";
            string space = "";
            int length = 0;
            for (int i = 0; i < 60; i++)
            {
                length = space.Length + goodBey.Length;
                if (length <= 60)
                {
                    Console.WriteLine(space + goodBey);
                    Thread.Sleep(0080);
                    Console.Clear();
                }
                else if (length > 60)
                {
                    goodBey=goodBey.Substring(0, goodBey.Length-1);
                    Console.WriteLine(space + goodBey);
                    Thread.Sleep(0080);
                    Console.Clear();
                }
                space += " ";
            }
            Console.WriteLine("THANK YOU FOR YOUR TIME.".PadLeft(40));
            Thread.Sleep(2000);
            Console.Clear();
            Environment.Exit(0);
        }
    }
}



//dictionary with list by name and surname
// vienu metu vienas zaidejas, galima atsijungti ir ziasti kitam ziadejui.
// 
// Print out the dictionary
//foreach (var outerEntry in myDictionary)
//{
//    Console.WriteLine($"Outer Key: {outerEntry.Key}");
//    foreach (var innerEntry in outerEntry.Value)
//    {
//        Console.WriteLine($"Inner Key: {innerEntry.Key}, Value: {innerEntry.Value}");
//    }
//}