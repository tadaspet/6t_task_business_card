namespace DirctorySteamReaderWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using streams
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
            var writer = new StreamWriter("CDriveDirs.txt");
            foreach (var dir in cDirs)
            {
                writer.WriteLine(dir.Name);
            }
            writer.Dispose();

            string line = "";
            using (var reader = new StreamReader("CDriveDirs.txt"))
            {
                while (line != null)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                }

            }
        }
    }
}