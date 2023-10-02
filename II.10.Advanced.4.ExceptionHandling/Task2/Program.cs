namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            ////Delcare an array of max index 4
            //int[] arr = { 1, 2, 3, 4, 5 };

            //// display values of array elements
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //// Try to access invalid index of array
            ////Console.WriteLine(arr[7]);
            //// An execption is thrown upon executing
            //// the above line

            //try
            //{
            //    int num1 = arr[7];
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Exception: " + ex.ToString());
            //}
            #endregion

            #region Task 3
            try
            {
                int[] ints = { 19, 0, 75, 52 };
                // Try to generate an execption
                for (int i = 0;i < ints.Length; i++)
                {
                    Console.WriteLine(ints[i] / ints[i+1]);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception By Zero Division: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine($"Exception Index Out Of Range: {ex2.Message}");
            }
            #endregion
        }
    }
}