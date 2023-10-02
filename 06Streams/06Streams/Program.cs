namespace _06Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string content = File.ReadAllText("C:\\NETUA2 class exercises\\paragraph.txt");
            //File.WriteAllText("C:\\NETUA2 class exercises\\New files\\newparagraph.txt", content);
            string content = File.ReadAllText("paragraph.txt");
            File.WriteAllText("newparagraph.txt", content);

            IEnumerable<string> contentLines = File.ReadLines("paragraph.txt");
            for (int i = 0; i < contentLines.Count(); i++)
            {
                if (contentLines.ElementAt(i).Contains("Main"))
                {
                    Console.WriteLine($"Main metodas prasideda euluteje {i + 1}");
                    break;
                }
            }
            File.WriteAllText("C:\\NETUA2 class exercises\\New files\\newparagraph.txt", string.Join(Environment.NewLine, contentLines));
        }
    }
}