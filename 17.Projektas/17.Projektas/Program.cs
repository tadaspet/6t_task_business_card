using System.Diagnostics.CodeAnalysis;

namespace _17.Projektas
{
    public class Projektas_ProtMusis
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users;
            //Dictionary<int, string> menu;
            string currentUser;
            int menuSelection;
            bool quit;
            string category;
            IOrderedEnumerable<KeyValuePair<string, int>> sortedScores;
            Console.WriteLine("Hello, welcome to the Quiz Game!");
            FirstUser(out users, out currentUser);
            Thread.Sleep(1000); 
            Console.Clear();
            NewUser(users, out currentUser);
            LargestsLakesOfContinents(currentUser, users, out category);
            Thread.Sleep(1000);
            Console.Clear();
            CapitalPopulation2023(currentUser,users, out category);
            //PrintMenu(currentUser);
            //MenuAction(out menuSelection);
            Thread.Sleep(1000);
            Console.Clear();
            NewUser(users, out currentUser);
            LargestsLakesOfContinents(currentUser, users, out category);
            Thread.Sleep(1000);
            Console.Clear();
            NewUser(users, out currentUser);
            CapitalPopulation2023(currentUser, users, out category);
            Thread.Sleep(1000);
            Console.Clear();
            TotalCategoryResultsTable(users);
            Console.WriteLine();
            CalculatedAndSorted(users,out sortedScores);
            PrintSortedScores(users);
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user.Key);
            //}
            //Console.WriteLine(currentUser);

        }
        public static void FirstUser(out Dictionary<string, Dictionary<string, int>> usersBook, out string currentUser)
        {
            usersBook = new Dictionary<string, Dictionary<string,int>>();
            Console.WriteLine("Please register in the system by Name and Surname:");
            currentUser = Console.ReadLine();
            usersBook.Add(currentUser, new Dictionary<string,int>());
            CategoryKeys(usersBook);
        }
        public static void NewUser(Dictionary<string, Dictionary<string, int>> users, out string currentUser)
        {
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
            CategoryKeys(users);
        }

        public static void MenuAction(out int menuSelection)
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
                }
            }
            if (menuOption < 6 && menuOption > 0 && menuInput != "q")
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Lets go to check the rules.");
                        menuSelection = 1;
                        break;
                    case 2:
                        menuSelection = 2;
                        Console.WriteLine("LET THE GAME BEGIN!");
                        break;
                    case 3:
                        menuSelection = 3;
                        Console.WriteLine("Interesting Analytics wil be shown.");
                        break;
                    case 4:
                        menuSelection = 4;
                        Console.WriteLine("New person - new results :)");
                        break;
                    case 5:
                        menuSelection = 5;
                        Console.WriteLine("We will meet another time...");
                        break;
                    default:
                        Console.WriteLine("Try another menu option:");
                        break;
                }
            }
            else if (!menuCheck)
            {
                Console.WriteLine("Try to login again");
            }
        }
        public static void PrintMenu(string currentUser)
        {
            Console.WriteLine($"Current player - {currentUser}.");
            Console.WriteLine("Choose menu action by number:");
            Dictionary<int, string> menu = new Dictionary<int, string>()
            {   {1, "Rules" },
                {2, "Start Game" },
                {3, "Statistics" },
                {4, "Change User" },
                {5, "Quit Game" }
            };
            foreach(var optionKeyValuePair  in menu)
            {
                Console.WriteLine(optionKeyValuePair.Key + ". " + optionKeyValuePair.Value);
            }
        }
        public static void CapitalPopulation2023(string currentUser, Dictionary<string, Dictionary<string, int>> users, out string category)
        {
            category = "Cities";
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
            Thread.Sleep(1000);
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
                int userAnswer = Convert.ToInt32(Console.ReadLine());
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
                Thread.Sleep(1000);
                Console.Clear();
            }
            users[currentUser]["Cities"] = pointAmount;
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            Console.WriteLine("Category Cities summary.".PadLeft(35));
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
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            ByCategoryResultsTable(users, category);
            Console.ReadLine();
            Console.Clear();
        }
        public static void LargestsLakesOfContinents(string currentUser, Dictionary<string, Dictionary<string, int>> users, out string category)
        {
            category = "Lakes";
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
            Thread.Sleep(1000);
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
                int userAnswer = Convert.ToInt32(Console.ReadLine());
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
                Thread.Sleep(1000);
                Console.Clear();
            }
            users[currentUser]["Lakes"] = pointAmount;
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            Console.WriteLine("Category Lakes summary.".PadLeft(35));
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
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            ByCategoryResultsTable(users, category);
            Console.ReadLine();
            Console.Clear();
        }
        public static void MountainCOuntries(string currentUser, Dictionary<string, Dictionary<string, int>> users, out string category)
        {
            category = "Mountain";
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
            Thread.Sleep(1000);
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
                int userAnswer = Convert.ToInt32(Console.ReadLine());
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
                Thread.Sleep(1000);
                Console.Clear();
            }
            users[currentUser]["Mountain"] = pointAmount;
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            Console.WriteLine("Category Mountain summary.".PadLeft(35));
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
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Current player - {currentUser}\nPoints - {pointAmount}\n\n");
            ByCategoryResultsTable(users, category);
            Console.ReadLine();
            Console.Clear();
        }
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
            Console.WriteLine($"     Players Records sorted by {category}");
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