using System.Xml.XPath;

namespace II._10.Advanced._4.ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Examples #1
            //try
            //{
            //    int[] nums = { 2, 3, 4, 5, 6, 7, 8, 2, 9, 21, 163 };

            //    int num0 = 0;
            //    int result = 10 / num0;
            //    Console.WriteLine(result);
            //    Console.WriteLine(nums[3]);
            //    Console.WriteLine(nums[50]);
            double num00 = 0;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Exception zero: " + ex.Message.ToString());
            //}
            ////catch (Exception ex)
            ////{
            ////    Console.WriteLine("Exception: " + ex.Message.ToString());
            ////}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Exception Index out of range: " + ex.Message.ToString());
            //}
            //finally 
            //{
            //    Console.WriteLine("The End");
            //}
            #endregion

            #region Example #2
            try
            {
                ValidateAge(15);
                ValidateAge(-10);
            }
            catch (InvalidAgeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception: " + ex.Message);
                Console.ResetColor();
            }
        }
        static void ValidateAge(int age)
        {
            if (age < 0) 
            {
                throw new InvalidAgeException($"{DateTime.Now} ivyko klaida ValidateAge metode age={age}");            
            }
        }
        #endregion
    }
}