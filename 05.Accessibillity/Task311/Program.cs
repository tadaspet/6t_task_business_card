namespace Task311
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle newCricle = new Circle(5);
            Console.WriteLine($"Circle area: {newCricle.CalculateArea()}");
        }
    }
}