namespace Task222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 11
            IEnumerable<string> textLines = File.ReadLines("1000overlines.txt");

            List<string> newLines = new List<string>();
            foreach (string line in textLines)
            {
                string count = line.Length.ToString();
                newLines.Add(count);
            }
            File.WriteAllText("1000sums.txt", string.Join(Environment.NewLine, newLines));
            #endregion

            #region Task 12

            //var writer = new StreamWriter("NewStreamWrited.txt");
            //double noCount = 0;
            //double symbSum = 0;
            //foreach (string line in textLines)
            //{
            //    int count = line.Length;
            //    writer.WriteLine(count + " = " + line);
            //    noCount++;
            //    symbSum += count;
            //}
            //writer.WriteLine("Average = " + symbSum/noCount);
            //writer.Dispose();

            #endregion

            #region Task 13

            using (BinaryWriter writer1 = new BinaryWriter(File.Open("test.dat", FileMode.Create)))
            {
                writer1.Write(1.250F);
                writer1.Write(@"Hello");
                writer1.Write(10);
            }

            using (BinaryReader reader1 = new BinaryReader(File.Open("test.dat", FileMode.Open)))
            {
                Console.WriteLine(reader1.ReadSingle());
                Console.WriteLine(reader1.ReadString());
                Console.WriteLine(reader1.ReadInt32());
            }

            #endregion


        }
    }
}