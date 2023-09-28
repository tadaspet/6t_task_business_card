namespace _8.Unit_Testing
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTextLength(" Hello ", false));
        }
        
        public static int GetTextLength(string text, bool includeLeadSpace)
        {
            if (!includeLeadSpace)
            {
                return text.Trim().Length;
            }
            else
            {
                return text.Length;
            }
        }
    }
}