public static class MethodTasks
{
    public static void Main(string[] args)
    {
    }
    #region examples not full

    //namespace WhileTema
    //{
    //    public static class Metodai
    //    {
    //        public static int CalculateAge(DateTime Brithday)
    //        {
    //            return DateTime.Now.Year - Brithday.Year;
    //        }
    //    }
    //}


    //using System.Threading.Channels;

    //public static int AskForNumber()
    //{
    //    Console.Write("Enter a number");
    //    string inPut = Console.ReadLine();
    //    bool isValid = int.TryParse(Console.ReadLine(), out _);
    //}
    #endregion

    #region No 1
    //Console.WriteLine("Enter password: ");
    //string password = Console.ReadLine();
    //bool IsValid = IsPasswordValid(password);
    //Console.WriteLine(IsValid);

    //Console.WriteLine("Enter email: ");
    //string email = Console.ReadLine();
    //bool IsValid2 = IsEmailValid(email);
    //Console.WriteLine(IsValid);

    //Console.WriteLine("Enter Dollar Amount:");
    //double dolSum = Convert.ToDouble(Console.ReadLine());
    //Console.WriteLine(ConvertToEuros(dolSum));

    //bool IsPasswordValid(string password)
    //{
    //    return password.Length > 8;

    //}

    //bool IsEmailValid(string email)
    //{
    //    return (email.Contains("@") && email.Contains("."));
    //}

    //double ConvertToEuros(double money)
    //{
    //    return dolSum * 0.85;
    //}
    #endregion

    #region No 2
    ///////2.1///
    //Console.WriteLine("Enter your Name:");
    //string name2 = Console.ReadLine();
    //Console.WriteLine("Enter your Surname:");
    //string surName2 = Console.ReadLine();
    //Console.WriteLine(GetInitials(name2, surName2));

    //string GetInitials(string name, string surName)
    //{
    //    string initials = $"{char.ToUpper(name[0])}.{char.ToUpper(surName[0])}.";
    //    return initials;
    //}
    /////2.2///
    //Console.WriteLine("Please enter Radius of cylinder:");
    //double radius = Convert.ToDouble(Console.ReadLine());
    //Console.WriteLine("Enter the Height of the cylinder");
    //double height = Convert.ToDouble(Console.ReadLine());
    //Console.WriteLine($"Volume of cylinder: {CalculateCylinderVolume(radius, height)}");
    //double CalculateCylinderVolume(double calcRad, double calcHeight)
    //{
    //    return (Math.PI*Math.Pow(calcRad,2)  * calcHeight);
    //}
    ///2.3///

    #region Tested Method1
    //Console.WriteLine("Please enter number:");
    //int numEven = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(IsNumberEven(numEven));

    public static bool IsNumberEven(int noCheck)
    {
        return (noCheck % 2 == 0);
    }
    #endregion
    /////2.4///
    //Console.WriteLine("Please enter reactangle Width:");
    //double width = Convert.ToDouble(Console.ReadLine());
    //Console.WriteLine("Enter the rectangle Height:");
    //double height2 = Convert.ToDouble(Console.ReadLine());
    //Console.WriteLine($"Ractangle area: {CalculateRectangleArea(width, height2)}");
    //double CalculateRectangleArea(double calcWidth, double calcHeight2)
    //{
    //    return calcWidth * calcHeight2;
    //}
    #endregion

    #region No 3.1
    public static int FactorialNumber(int faktorial3)
    {
        //Console.WriteLine("Enter number to count factorial number:");
        //int faktorial3 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(multFaktorial(faktorial3));
        //int multFaktorial(int faktorial3)
        {
            if (faktorial3 == 1)
            {
                return 1;
            }
            else
            {
                //Console.WriteLine(faktorial3);
                return faktorial3 * FactorialNumber(faktorial3 - 1);

            }
        }
    }
    #endregion

    #region No 3.2
    //Console.WriteLine("Enter Fiboncci number:");
    //int fibNo = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine($"Finbonacci sequence answer - {FibMethod(fibNo)}");
    //int FibMethod(int fibNo)
    //{
    //    if (fibNo <= 1)
    //    {
    //        return fibNo;
    //    }
    //    else
    //    {
    //        return FibMethod(fibNo - 1) + FibMethod(fibNo - 2);
    //    }
    //}
    #endregion

    #region Recursion example
    //Console.WriteLine("Recursion");
    //Recursion(5);
    //void Recursion(int number)
    //{
    //    if (number == 0)
    //    {
    //        return;
    //    }
    //    Console.WriteLine(number);
    //    Recursion(number - 1);
    //}
    #endregion

    #region Fibonacci example
    //Fibonacci(0, 1);
    public static int Fibonacci(int fibNo1, int fibNo2)
    {
        int result = fibNo1 + fibNo2;

        if (result > 55)
        {
            return result;
        }
        Console.WriteLine(result);
        return Fibonacci(fibNo2, result);
    }
    #endregion
}
