using System.Security.Cryptography.X509Certificates;
using System;

namespace _10.For_Cicle
{
    public class ForCicles10
    {
        static void Main(string[] args)
        {
            #region Example No 1
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Example No 2
            //for (int k = 0; k <= 10; k+=2)
            //{
            //    Console.WriteLine(k);
            //}
            #endregion

            #region Example Bad practices 1
            //int k = 0;
            //for (int k = 2; k <= 10; k++) //additional variable creation before cicle starts.
            //{
            //    Console.WriteLine(k);
            //}

            //for (int i = 0; i <= 10; i++) //iteration variable changes inside the cicle for 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 0; i++) // infinite loop, there is no definition of end
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Task 1.4
            //Console.WriteLine("-------Task_1.4-------");
            //Console.WriteLine("Enter number for arimetrical mean of numbers sequence:");
            //double amount14 = Convert.ToDouble(Console.ReadLine());
            //double calc14 = 0;
            //for (double i = 1; i <= amount14; i++)
            //{
            //    calc14 += i;
            //}
            //double mean = Math.Round((calc14 / amount14),2);
            //Console.WriteLine($"Sum of numbers:{calc14}\nArimetrical mean:{mean}");
            //Console.WriteLine("----------END---------");
            #endregion

            #region Task 1.5 
            //Console.WriteLine("-------Task_1.5-------");
            //Console.WriteLine("Enter number of stars");
            //double amount15 = Convert.ToDouble(Console.ReadLine());
            //for (double i = 1; i <= amount15; i++)
            //{
            //    Console.WriteLine("*"); ;
            //}
            //Console.WriteLine("----------END---------");
            #endregion

            #region Task 1.6 Alternative with IFs
            //Console.WriteLine("-------Task_1.6-------");
            //string amount16 = Console.ReadLine();
            //double trueAmount;
            //bool check16 = double.TryParse(amount16, out trueAmount);
            //double div3 = Math.Floor(trueAmount / 3);
            //if (!check15)
            //{
            //    Console.WriteLine("Number is not valid.");
            //}
            //else if (div3 >=1)
            //{
            //    Console.WriteLine($"There are {div3} division from the input number {amount16}");
            //    for (double i = 1; i <= div3; i ++)
            //    {
            //        Console.WriteLine(i*3);
            //    }
            //}
            //else if (div3 < 1)
            //{
            //    Console.WriteLine("Number is to small to be divided by 3");
            //}
            //Console.WriteLine("----------END---------");
            #endregion

            #region Task 1.6
            //Console.WriteLine("-------Task_1.6-------");
            //int check16 = 100 / 3;
            //Console.WriteLine("1");
            //for (int i =1; i <= check16; i++)
            //{
            //    Console.WriteLine(3+(i-1)*3);
            //}
            //Console.WriteLine("----------END---------");
            #endregion

            #region Additional 1
            Console.WriteLine("-------Extra 1-------");
            int max = 9;
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"Multiplication by {i}");
                for (int j = 1; j <= max; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            Console.WriteLine("----------END---------");
            #endregion

            #region Additional Fermat's Prime 
            //Console.WriteLine("-------Extra 2-------");
            //Console.WriteLine("Enter number");
            //int amount2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= amount2; i++)
            //{
            //    double primeNo = (Math.Pow(2, i) - 1);
            //    Console.WriteLine($"Fermat's prime number {i} is {primeNo}");
            //}
            //Console.WriteLine("----------END---------");
            #endregion

            #region Additional Prime
            //int pirm = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i <= pirm; i++)
            //{
            //    bool reminderCheck = false;
            //    int intReminder = 0;
            //    for (int j = 2; j < i; j++) 
            //    {
            //        intReminder = i % j;
            //        if (intReminder == 0)
            //        {
            //            reminderCheck = true;
            //        }
            //    }
            //    if (!reminderCheck)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region DBD
            //int dbd1 = Convert.ToInt32(Console.ReadLine());
            //int dbd2 = Convert.ToInt32(Console.ReadLine());
            //bool checkVS= dbd1 > dbd2;
            //if (checkVS)
            //{

            //    for (int i = dbd2; i >= 1;  i--)
            //    {
            //        bool check1 = dbd1 % i == 0;
            //        bool ckeckSelf1 = dbd2 % i == 0;
            //        if (check1 && ckeckSelf1 && (i > 1))
            //        {
            //            Console.WriteLine($"Didziausias bendrasis daliklis yra {i}");
            //            break;
            //        }
            //        if (i == 1)
            //        {
            //            Console.WriteLine($"Skaiciai {dbd1} ir {dbd2} neturi bendro daliklio.");
            //        }
            //    }
            //}
            //if (!checkVS)
            //{

            //    for (int j = dbd1; j >= 1; j--)
            //    {
            //        bool check2 = dbd2 % j ==0;
            //        bool ckeckSelf2 = dbd1 % j == 0;
            //        if (check2 && ckeckSelf2 && (j > 1))
            //        {
            //            Console.WriteLine($"Didziausias bendrasis daliklis yra {j}");
            //            break;
            //        }
            //        if (j == 1)
            //        {
            //            Console.WriteLine($"Skaiciai {dbd1} ir {dbd2} neturi bendro daliklio.");
            //        }
            //    }
            //}
            //if (dbd1 == dbd2)
            //{
            //    Console.WriteLine($"Skaiciu bendras daliklis yra {dbd1}");
            //}
            #endregion
        }
        #region Task 1.1
        //Console.WriteLine("-------Task_1.1-------");
        public static int PrintOnlyEvenNumbers(int a)
        {
            int b = 0;
            for (int i = 0; i <= a; i += 2)
            {
                Console.WriteLine(i);
                b++;
            }
            return b;
            //Console.WriteLine("----------END---------");
        }
        #endregion

        #region Task 1.2
        public static int SumofUserInputNumber(int b)
        {
            //Console.WriteLine("-------Task_1.2-------");
            //Console.WriteLine("Enter number for Addition:");
            //double amount12 = Convert.ToDouble(Console.ReadLine());
            int Sum = 0;
            for (int i = 0; i <= b; i++)
            {
                Sum += i;
            }
            return Sum;
            //Console.WriteLine(Sum);
            //Console.WriteLine("----------END---------");
        }
        #endregion
        #region Task 1.3
        public static double SquareExponentByTheUserInput(double c)
        {
            //Console.WriteLine("-------Task_1.3-------");
            //Console.WriteLine("Enter number for Squared numbers sequence:");
            //int amount13 = Convert.ToInt32(Console.ReadLine());
            //c = 10;
            double squarePrint = 1;
            Console.WriteLine("Square Exponents:");
            for (int i = 1; i <= c; i++)
            {
                squarePrint = Math.Pow(i, 2);
                Console.WriteLine($"Number {i} squared is {squarePrint}");
            }
            return squarePrint;
            //Console.WriteLine("----------END---------");
        }
        #endregion
    }
}