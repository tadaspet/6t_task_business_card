namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            try
            {
                double try2 = Convert.ToDouble("twelve");
            }
            catch (FormatException e1)
            {
                Console.WriteLine($"Convert.ToDouble.FormatException.Exception : {e1.Message} ");
            }
            try
            {
                List<double> list = new List<double> { 2.22, 3.33, 4.44 };
                double list2 = Convert.ToDouble(list);
            }
            catch (InvalidCastException e2)
            {
                Console.WriteLine($"Convert.ToDouble.InvalidCastException.Exception : {e2.Message} ");
            }
            try
            {
                double pow = Math.Pow(0, 999999999999);
            }
            catch (OverflowException e3)
            {
                Console.WriteLine($"Convert.ToDouble.OverFlow.Exception : {e3.Message} ");
            }
            Console.WriteLine("--------------");
            #endregion
        }
    }
}