namespace _07.Advanced.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ShowItem("text");
            //ShowItem(123);

            //ShowItem<string>("T identification text");
            //ShowItem<int>(123);

            //ShowItem<Human>(new Human("Tadas", "Petruitis"));

            //var myHuman = new Human("Tadas", "Petruitis");
            //var myString = "new generic type";
            //var myInteger = 3;
            //Console.WriteLine("--------------");
            //Console.WriteLine(GetTypeName<Human>(myHuman));
            //Console.WriteLine(GetTypeName<string>(myString));
            //Console.WriteLine(GetTypeName<int>(myInteger));
            //Console.WriteLine("--------------");
            //Console.WriteLine(myInteger.GetType().Name);
            //Console.WriteLine(myString.GetType().Name);
            //Console.WriteLine(myHuman.GetType().Name);

            //var mySelfMadeList = new MySelfMadeList<int>();

            //for (int i = 0; i < 1000; i++)
            //{
            //    mySelfMadeList.AddElement(i);
            //}
            //var newVal = new Validation<string>();
            //newVal.Validate("text");
            //newVal.Validate("");
            //newVal.Validate<string>(null);
            //newVal.Validate<int>(0);

            //Validation<string>.Validate<string>(null);

            //List<int> listInt = new List<int> {1,3,6,28 };
            //List<string> listString = new List<string> { "one", "trys", "šeši", "dvidesimtastuoni" };
            //listInt.Add("five");
            //listString.Add(1);
            //List<object> listObj = new List<object>();
            //Console.WriteLine("----------------");
            //listObj.Add(1);
            //listObj.Add("trys");
            //listObj.Add(new Human("Tadas", "Petruitis"));
            //listObj.Add(mySelfMadeList);

            //foreach (int i in listObj)
            //{
            //    Console.WriteLine(i);
            //}

            //ShowTwoItems<string, Human>("Hello, World!", new Human("Vardesnis", "Pavardenis"));

            #region Task 311
            //Console.WriteLine("--------------------------\n");
            //var printGenericsTask = new Task311<string, int>();
            //printGenericsTask.ShowValues<string, int>("Generic text", 13);
            //Console.WriteLine("\n--------------------------\n");
            //printGenericsTask.ShowValues<int, Human>(12, new Human("Vardesnis", "Pavardenis"));
            //Console.WriteLine("\n--------------------------\n");
            //List<string> newStringList = new List<string> {"Labas","Hello","Hallo" };
            //printGenericsTask.ShowValues<List<string>, string>(newStringList, "Pavardenis");
            #endregion


            #region Task 411

            var newMySelfMadeList = new MySelfMadeList<int>();

            for (int i = 0; i < 10; i++)
            {
                newMySelfMadeList.AddElement(i);
            }

            newMySelfMadeList.DeleteElement(3);



            #endregion

        }
        public static void ShowItem<T>(T item)
        {
            Console.WriteLine($"Item: {item}");
        }
        public static void ShowTwoItems<T1, T2>(T1 item1, T2 item2)
        {
            Console.WriteLine($"Item1: {item1}; item2: {item2}");
        }
        public static string GetTypeName<T>(T item)
        {
            return item.GetType().Name;
        }
    }
}