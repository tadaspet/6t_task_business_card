namespace Task111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            string content = File.ReadAllText("OnlyStrings.txt");
            Console.WriteLine($"10 most common methods of C#:" +
                $"\n{content}");

            #endregion

            #region Task2

            List<string> list = new List<string>()
            {"ToString()","Equals(Object)","GetHashCode()","GetType()","Substring(int32)","Split(Char[])",
            "Replace(String, String)","Trim()","ToLower()","ToUpper()"};

            File.WriteAllLines("OnlyStrings.txt", list);

            #endregion

            #region Task3

            File.Copy("OnlyStrings.txt", "NewOnlyStrings.txt");

            #endregion

        }
    }
}