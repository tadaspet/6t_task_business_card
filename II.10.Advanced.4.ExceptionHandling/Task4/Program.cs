namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileReader test = new FileReader();
                test.FilePath = ""; //"C:\\NETUA2 class exercises\\Advanced 4\\10list.txt";
                test.ReadFile();
            }
            //when assambly can not be loaded
            catch (FileLoadException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}