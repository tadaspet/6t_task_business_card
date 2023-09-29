namespace _16.Dictionary
{
    public class DictionaryTasks
    {
        static void Main(string[] args)
        {
            #region Lesson examples BASIC
            //Dictionary<string, int> miestai = new Dictionary<string, int>()
            //{
            //    { "Vilnius", 7 },
            //    { "Kaunas", 6 },
            //    { "Siauliai", 8 },
            //    { "Jonava", 6 }
            //};

            //List<string> citiesList = new List<string>()
            //{
            //    "Vilnius",
            //    "Kaunas",
            //    "Siauliai",
            //    "Jonava"
            //};

            //Dictionary<string, List<int>> zaidejuTaskuZodynas = new Dictionary<string, List<int>>()
            //{
            //    { "Ieva", new List<int>() { 9, 8, 10} },
            //    { "Audrius", new List<int> { 8, 10, 8, 10, 10} },
            //    { "Veronika", new List<int>{ 10, 10, 10} }
            //};

            //Console.WriteLine("PRINTING DICTIONARY:");
            //foreach(KeyValuePair<string, int> city in miestai) // KeyValuePair can be as var
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", city.Key, city.Value);
            //}

            //Console.WriteLine("PRINTING DICTIONARY in teachers way:");
            //foreach (var cityKeyValuePair in miestai)
            //{
            //    Console.WriteLine($"{cityKeyValuePair.Key} - {cityKeyValuePair.Value} ");
            //}

            //Console.WriteLine("PRINTING LIST:");
            //foreach (string cite in citiesList)
            //{
            //    Console.WriteLine(cite);
            //}

            //Console.WriteLine("PRINTING DICTIONARY with value LIST:");
            //foreach (var zaidejasKeyValuePair in zaidejuTaskuZodynas)
            //{
            //    Console.Write($"Zaidejas: {zaidejasKeyValuePair.Key} - ");

            //    foreach (int taskai in zaidejasKeyValuePair.Value)
            //    {
            //        Console.Write(taskai + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////Read value from the dictionary
            //Console.WriteLine("Siauliai skaicius: " + miestai["Siauliai"]);

            ////Add value into the dictionary
            //miestai["Londonas"] = 20;
            //miestai["Siauliai"] = 18;

            //Console.WriteLine("PRINTING UPDATED DICTIONARY in teachers way:");
            //foreach (var cityKeyValuePair in miestai)
            //{
            //    Console.WriteLine($"{cityKeyValuePair.Key} - {cityKeyValuePair.Value} ");
            //}

            #endregion

            #region DICTIONARY METHODS
            //Dictionary<string, int> miestai = new Dictionary<string, int>()
            //{
            //    { "Vilnius", 7 },
            //    { "Kaunas", 6 },
            //    { "Siauliai", 8 },
            //    { "Jonava", 6 },
            //    { "New York", 50 }
            //};

            //// Conatains grazina bool tipo reiksme
            //if (miestai.ContainsKey("New York"))
            //{
            //    Console.WriteLine("New York skaicius: " + miestai["New York"]);
            //}
            //else
            //{
            //    Console.WriteLine("Dictionary nera miesto: 'New York'");
            //}

            ////Ar dictionary egzituoja irasas su nurodomu value

            //if (miestai.ContainsValue(3))
            //{
            //    Console.WriteLine("Egzistuoja miestas us reiksme 7");
            //}
            //else
            //{
            //    Console.WriteLine("Miesto su tokia reiksme dictionary nera");
            //}

            ////Istrinti reiksme is dictionary
            //Console.WriteLine("Miestu Zodynas");
            //foreach (var key in miestai.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //miestai.Remove("New York");
            //Console.WriteLine("Redaguotas miestu Zodynas");
            //foreach (var key in miestai.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            ////attrenkami tik dictionary Keys
            //Console.WriteLine("Pritning dictionary Keys");
            //foreach (var key in miestai.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            ////attrenkami tik dictionary Values
            //Console.WriteLine("Pritning dictionary Values");
            //foreach (var value in miestai.Values)
            //{
            //    Console.WriteLine(value);
            //}
            #endregion



            #region 1.1
            //Console.WriteLine("------Task 1.1------");
            //NewDictionaryNameAge();
            //Console.WriteLine("------END-----------");
            #endregion

            #region 1.2
            //Console.WriteLine("------Task 1.2------");
            //string input = Console.ReadLine();
            //CountryCapitals(input);
            //Console.WriteLine("------END-----------");
            #endregion

            #region 1.3
            //Console.WriteLine("------Task 1.3------");
            //Dictionary<string, int> fruits = new Dictionary<string, int>()
            //{
            //    {"Apples", 3 },
            //    {"Pears", 5 },
            //    {"Bananas", 2 },
            //    {"Lemon", 4 }
            //};
            //PrintDictionary(fruits);
            //Console.WriteLine("Update fruit basket.\nEnter new or existing fruit, after it quantity:");
            //string fruit = Console.ReadLine();
            //int quantity = Convert.ToInt32(Console.ReadLine());
            //FruitQuantityList(fruits, fruit, quantity);
            //Console.WriteLine("New basket priting:");
            //PrintDictionary(fruits);
            //Console.WriteLine("------END-----------");
            #endregion

            #region 2.1
            //Console.WriteLine("------Task 2.1------");
            //Dictionary<string, int> population = new Dictionary<string, int>()
            //{
            //    {"Vilnius", 630885 },
            //    {"Warsaw", 1798000 },
            //    {"Berlin", 3850809 },
            //    {"Paris", 2102650 }
            //};
            //PrintDictionaryKeys(population);
            //Console.WriteLine("Type city name after list to see the population quantity.");
            //string input = "";
            //int check = 0;
            //while (check == 0 )
            //{
            //    input = Console.ReadLine();
            //    check = CheckDictionaryIntValue(population, input);
            //    if (check == 0)
            //    {
            //        Console.WriteLine("Typing mistake");
            //    }
            //}
            //Console.WriteLine($"Population of {input} is {check}");
            //Console.WriteLine("------END-----------");
            #endregion

            #region 2.2
            //Console.WriteLine("------Task 2.2------");
            //Console.WriteLine("Translate to Lithiaunian:");
            //Dictionary<string, string> translate = new Dictionary<string, string>()
            //{
            //    {"Hello", "Labas" },
            //    {"What", "Koks" },
            //    {"Is", "Yra" },
            //    {"Your", "Tavo" },
            //    {"Name", "Vardas" }
            //};
            //PrintDictionaryStringKeys(translate);
            //Console.WriteLine("Enter word to be translated:");
            //string input = "";
            //string translation = "";
            //while (translation == "" || translation == "False")
            //{
            //    input = Console.ReadLine();
            //    translation = CheckDictionaryStringtValue(translate, input);
            //    if (translation == "False")
            //    {
            //        Console.WriteLine("Typing mistake, re-eneter:");
            //    }
            //}
            //Console.WriteLine($"English '{input}' in Lithuanian - '{translation}'");
            //Console.WriteLine("------END-----------");
            #endregion

            #region 2.3
            //Console.WriteLine("------Task 2.3------");

            //Console.WriteLine("------END-----------");
            #endregion
        }
        static public void NewDictionaryNameAge()
        {
            Dictionary<string, int> zmones = new Dictionary<string, int>();
            string[] vardai = { "Karolis", "Jonas", "Vilius" };
            Random random = new Random();
            for (int i = 0; i < vardai.Length; i++)
            {
                zmones.Add(vardai[i], random.Next(1,100));
            }
            foreach(var zmonesKeyValuePair in zmones)
            {
                Console.WriteLine($"Vardas - {zmonesKeyValuePair.Key}, amzius - {zmonesKeyValuePair.Value}");
            }
        }
        static public string CountryCapitals(string input)
        {
            Dictionary<string, string> geogr = new Dictionary<string, string>()
            {
                {"Lietuva", "Vilnius" },
                {"Latvija", "Ryga" },
                {"Estija", "Talinas" },
                {"Lenkija", "Varsuva" }
            };
            //Console.WriteLine("Salys:");
            //foreach (var geogrKeyValuePair in geogr)
            //{
            //    Console.WriteLine(geogrKeyValuePair.Key);
            //}
            //Console.WriteLine("Iveskite salies pavadinima:");
            //string input = Console.ReadLine();
            //if(geogr.ContainsKey(input))
            //{
                //Console.WriteLine($"Sostine - {geogr[input]}");
                return geogr[input];
            //}
            //else
            //{
            //    Console.WriteLine("Ivestis neteisinga");
            //}
        }
        static public void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (var nameKeyValuePair in dict)
            {
                Console.WriteLine($"{nameKeyValuePair.Key} - {nameKeyValuePair.Value}");
            }
        }
        static public void PrintDictionaryKeys(Dictionary<string, int> dict)
        {
            foreach (var nameKeyValuePair in dict)
            {
                Console.WriteLine(nameKeyValuePair.Key);
            }
        }
        static public void PrintDictionaryStringKeys(Dictionary<string, string> dict)
        {
            foreach (var nameKeyValuePair in dict)
            {
                Console.WriteLine(nameKeyValuePair.Key);
            }
        }
        static public void PrintDictionaryStringValue(Dictionary<string, string> dict)
        {
            foreach (var nameKeyValuePair in dict)
            {
                Console.WriteLine(nameKeyValuePair.Value);
            }
        }
        static public Dictionary<string,int> FruitQuantityList(Dictionary<string, int> dict, string fruitName, int quantNo)
        {
            //Dictionary<string, int> newList= new Dictionary<string, int>();
            if (dict.ContainsKey(fruitName))
            {
                dict[fruitName] = quantNo;
            }
            else
            {
                dict.Add(fruitName, quantNo);
            }
            return dict;
        }
        static public int CheckDictionaryIntValue(Dictionary<string, int> dict,string input)
        {
            if (dict.ContainsKey(input))
            {
                return dict[input];
            }
            else { return 0; }
        }
        static public string CheckDictionaryStringtValue(Dictionary<string, string> dict, string input)
        {
            if (dict.ContainsKey(input))
            {
                return dict[input];
            }
            else { return "False"; }
        }

    }
}