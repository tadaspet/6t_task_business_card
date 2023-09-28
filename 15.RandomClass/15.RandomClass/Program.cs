using System;
using System.Security.Cryptography.X509Certificates;

namespace _15.RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region class example 1
            //konstruojame naujus random

            //Random random = new Random();
            //int aRandomNumber = random.Next(); // bet koks skaicius nuo 0 iki Int32.maxValue
            //int aRandomNumber1 = random.Next(20);  // bus segeneruota 0,1,2, arba 3
            //int aRandomNumber2 = random.Next(8, 10); // bus sugeneruotas 1,2 arba 3

            //double dTandomNuber = random.NextDouble(); // >=0.0 iki <1.0

            //Console.WriteLine($"1st random {aRandomNumber}");
            //Console.WriteLine($"2nd random {aRandomNumber1}");
            //Console.WriteLine($"3rd random {aRandomNumber2}");
            //Console.WriteLine($"4th random {dTandomNuber}");
            #endregion

            #region class example 2
            //Random rnd1 = new Random(10);
            //Random rnd2 = new Random(10);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(rnd1.Next(100) + " ");
            //}

            //Console.WriteLine();
            //for (int i = 0;i < 5; i++)
            //{
            //    Console.WriteLine(rnd2.Next(100) + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Task 11 
            //Console.WriteLine("------Task11-------");
            //Console.WriteLine("Random numbers from 1 to 10");
            //RandomFrom1to10();
            //Console.WriteLine("--------END--------");
            #endregion

            #region Task 12
            //Console.WriteLine("------Task12-------");
            //bool answer = false;
            //Console.WriteLine("Type number of the bool values:");
            //int no = Convert.ToInt32(Console.ReadLine());
            //RandomBoolValue(no,answer);
            //Console.WriteLine("--------END--------");
            #endregion

            #region Task 13
            //Console.WriteLine("------Task13-------");
            //Console.WriteLine("Type number of password length");
            //int lengthPass = Convert.ToInt32(Console.ReadLine());
            //RandomABCLetter(lengthPass);
            //Console.WriteLine("--------END--------");
            #endregion

            #region Task 14
            //Console.WriteLine("------Task14-------");
            //Console.WriteLine("Sum of 100 numbers from 1 to 6");
            //SumOf100NumbersFrom1to6();
            //Console.WriteLine("--------END--------");
            #endregion

            #region Task 15
            //Console.WriteLine("------Task15-------");
            //Console.WriteLine("Guess random number if it is bigger or smaller then 50\nNumber range is from 1 to 100 and to answer type Yes/No.");
            //GuessNumberInRangeOf100();
            //Console.WriteLine("--------END--------");
            #endregion

            #region Task 3.1
            Console.WriteLine("------Task3.1-------");
            int[,] newMatrix;
            int countEven;
            int countOdd;
            RandomMatrixCreation(out newMatrix);
            PrintIntegerMatrixfromArray(newMatrix);
            MatrixNumberCheck(newMatrix, out countEven, out countOdd);
            Console.WriteLine($"Matrix had in total:\nEven no:{countEven}\nOdd no:{countOdd}");
            Console.WriteLine("--------END--------");
            #endregion

        }
        public static void RandomFrom1to10()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,11));
            }
        }
        public static void RandomBoolValue(int no, bool answer)
        {
            Random check = new Random();
            for(int i = 0;i < no ;i++)
            {
                int temp = check.Next(1,100);
                if (temp % 2 == 0)
                {
                    answer = true;
                    Console.WriteLine(answer);
                }
                else if (temp % 2 != 0)
                {
                    answer = false;
                    Console.WriteLine(answer);
                }

            }
        }
        public static void RandomABCLetter(int lengthPass)
        {
            char[] chars = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
            Random random = new Random();
            Console.WriteLine("Password:");
            for (int i =0; i < lengthPass; i++)
            {
                Console.Write((chars[random.Next(chars.Length)]));
            }
            Console.WriteLine();
        }
        public static void SumOf100NumbersFrom1to6()
        {
            Random random = new Random(); 
            int Sum = 0;
            int no = 0;
            for (int i = 0; i <100;i++)
            {
                no = random.Next(1, 7);
                Console.WriteLine($"No {i+1} = {no}");
                Sum += no;
                Console.WriteLine($"Sum:{Sum}");
            }
        }
        public static void GuessNumberInRangeOf100()
        {
            Random rand = new Random();
            for (int i = 0;i < 3;i++)
            {
                Console.WriteLine($"Guess no {i + 1} of 3");
                string answer = Console.ReadLine().ToLower();
                int secretNo = rand.Next(1, 101);
                if ((answer == "yes" && secretNo > 50) || (answer == "yes" && secretNo< 50))
                {
                    Console.WriteLine($"Congratulations, number was {secretNo}!");
                }
                else if (secretNo == 50)
                {
                    Console.WriteLine("Random made a joke it! Number was 50 :)");
                }
                else
                {
                    Console.WriteLine($"You were unlucky, number was {secretNo}.");
                }
                //if (secretNo > 50)
                //{
                //    if (answer == "yes")
                //    {
                //        Console.WriteLine($"Congratulations, number was {secretNo}!");
                //    }
                //    else if (answer == "no")
                //    {
                //        Console.WriteLine($"You were unlucky, number was {secretNo}.");
                //    }
                //}
                //else if (secretNo < 50)
                //{
                //    if (answer == "yes")
                //    {
                //        Console.WriteLine($"You were unlucky, number was {secretNo}.");
                //    }
                //    else if (answer == "no")
                //    {
                //        Console.WriteLine($"Congratulations, number was {secretNo}!");
                //    }
                //}
                //else if (secretNo ==50)
                //{
                //    Console.WriteLine("Random made a joke it! Number was 50 :)");
                //}

            }
        }
        public static void PrintIntegerMatrixfromArray(int[,] matrix)
        {
            Console.WriteLine("Priting...");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Console.ReadLine();
        }

        public static void RandomMatrixCreation(out int[,] matrix)
        {
            Random random = new Random();
            int rows = random.Next(1, 9);
            int cols = random.Next(1, 9);
            matrix = new int[rows, cols];
            List<int> listNo = new List<int>();
            int tempNo;
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for (int j = 0;j < matrix.GetLength(1); j++)
                {
                    tempNo = random.Next(j * 10, (j * 10 + 10));
                    while (listNo.Contains(tempNo))
                    {
                        tempNo = random.Next(j * 10, (j * 10 + 10));
                    }
                    matrix[i,j] = tempNo;
                    listNo.Add(tempNo);
                }
            }
        }
        public static void MatrixNumberCheck(int[,] matrix,out int countEven, out int countOdd)
        {
            countEven=0;
            countOdd=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] %2 == 0)
                    {
                        countEven++;
                    }
                    else
                    { 
                        countOdd++; 
                    }
                }
            }
        }
    }
}