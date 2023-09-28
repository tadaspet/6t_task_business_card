using System.ComponentModel;

namespace _13.Multidimensional_Arrays
{
    public class MultidimensionalArray
    {
        static void Main(string[] args)
        {
            #region Examples
            //string[] autos = new string[] { "BMW", "Audi", "Toyota" };

            //Console.WriteLine("Printing cars using For loop:");
            //for (int i = 0; i < autos.Length; i++)
            //{
            //    Console.WriteLine(autos[i]);
            //}

            //Console.WriteLine("Printing cars using Foreach loop:");
            //foreach (var car in autos)
            //{
            //    Console.WriteLine($"{car}");
            //}
            #endregion

            #region Task12
            //double[] numbers = { 1, 2, -3, -5, 6, 7 };
            //int count = numbers.Length;
            //printArray(ReturnPossitiveNumberArrary(numbers), count);
            #endregion

            #region Task122
            //double[] numbers = { 1, 2, 3, 5, 6, 7 };
            //int count = numbers.Length;
            //printArray(ReturnPossitiveNumberArrary(numbers), count);

            #endregion

            #region Task13
            //double[] numbers = { 100, 200, 3000, 600, 800 };
            //int count = numbers.Length;
            //printArray(ReturnTaxes(numbers), count);
            #endregion

            #region Task14
            //string sentence = "Koks pasaulis yra grazus ir nuostabus";
            //int count = SentenceReturn(sentence).Length;
            //printStringArray(SentenceReturn(sentence), count);
            #endregion
            #region Task2
            //string[] cardType = { "Clubs", "Spades", "Hearts", "Diamonds" };
            //string[] cardNo = { "9", "10", "J", "Q", "K", "A" };
            //int count = CardDeck(cardType, cardNo).Length;
            //printStringArray(CardDeck(cardType, cardNo),count);
            #endregion

            #region Multidimensional Array
            //int rows = 4;
            //int colums = 5;
            //int[,]  matrix = new int[rows, colums];

            ////Initialize the matrix with some values
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < colums; j++)
            //    {
            //        matrix[i, j] = i + j;
            //    }
            //}

            ////Display the matrix in the console
            //for (int i = 0;i < rows; i++)
            //{
            //    for (int j = 0;j < colums; j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion

            #region Table example

            //string[,] table = new string[3,3];

            //table[0, 0] = "Name";
            //table[0, 1] = "Age";
            //table[0, 2] = "City";

            //table[1, 0] = "John";
            //table[1, 1] = "25";
            //table[1, 2] = "New York";

            //table[2, 0] = "Jane";
            //table[2, 1] = "30";
            //table[2, 2] = "London";

            //PrintStringMatrix(table);

            //for (int i = 0;i<table.GetLength(0);i++)
            //{
            //    for (int j = 0; j< table.GetLength(1);j++)
            //    {
            //        Console.Write(table[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Task2.1
            //Console.WriteLine("--------Task2.1-----------");
            //Console.WriteLine("Enter 2D Array row number:");
            //int row = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2D Array column number:");
            //int column = Convert.ToInt32(Console.ReadLine());
            //PrintIntegerMatrixfromArray(MatrixCreatorTask21(row, column));
            //Console.WriteLine("------------END-----------");
            #endregion


            #region Task 2.2
            //int[,] array = { 
            //    { 2, 3, 5 } ,
            //    { 5, 6, 6 } , 
            //    { 9, 3, 7 } };
            //MatchFinderIntegerArray(array);
            #endregion

            #region Task 2.3
            //string[,] array2 = { 
            //    { "Vladas", "Kornelijus", "Kotryna" },                 
            //    { "Karolis", "Valdas", "Vladas" }, 
            //    { "Kristupas", "Kornelijus", "Karolis" } };
            //MatchFinderStringArray(array2);
            #endregion

            #region Task 2.4
            //int[,] matrix1 = { 
            //    { 2,7,4},
            //    {3,4,5 },
            //    {1,3,2 } };
            //int[,] matrix2 = { { 4 }, { 2}, { 2 } };
            //PrintIntegerMatrixfromArray(MatrixMultiplication3x1(matrix1, matrix2));
            #endregion

            #region Task 3.1
            //int[,] matrix3 = {{ 62,50,33}, {20,13,12 }, { 11, 62, 9 } };
            //int row;
            //int col;
            //int answer;
            //MaximumMatrixValue(matrix3,out row,out col,out answer);
            //PrintIntegerMatrixfromArray(matrix3);
            //Console.WriteLine($"Matrix max value: {answer}");
            //Console.WriteLine($"Row: {row+1}\nColumn: {col+1}");
            #endregion

            #region Task 3.2
            int[,] matrix32 = { { 1, -3, 7 }, { -3, 5, 4 }, { 7, 4, 3 } };
            int[,] result;
            int[,] result2;
            bool check;
            SimetricalMatrix(matrix32, out check, out result, out result2);
            Console.WriteLine("Original matrix:");
            PrintIntegerMatrixfromArray(matrix32);
            Console.WriteLine("Horizontal matrix:");
            PrintIntegerMatrixfromArray(result);
            Console.WriteLine("Vertical matrix:");
            PrintIntegerMatrixfromArray(result2);
            #endregion

            #region Task 3.3
            //Console.WriteLine("Sukurkime gyvenu lentele\nKiek gyvunu aprasysite?");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite gyvunu duomenis pagal stulpeliu eiliskuma:");
            //string[] header = { "Vardas", "Tipas", "Kailio Sp.", "Budas" };
            //AnimalTablePriting(header, count);
            #endregion

            #region Task 3.4
            //char[,] signs= new char[4,4];
            //PrintingPlusSpace(signs);

            #endregion

        }
        static void printArray(double[] arr, int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void printStringArray(string[] arr, int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(arr[i] + "\n");
            Console.WriteLine();
        }
        public static double AverageArray(double[] numbers)
        {
            double count = numbers.Length;
            double sum = 0;
            foreach (double i in numbers)
            {
                sum += i;
            }
            return sum / count;
        }

        public static double[] ReturnPossitiveNumberArrary(double[] numbers)
        {
            double[] result = new double[numbers.Length];
            int index = 0;
            foreach (double i in numbers)
            {
                if (i > 0)
                {
                    result[index] = i;
                    index++;
                }
                
            }
            return result;
        }

        public static double[] ReturnTaxes(double[] numbers)
        {
            double afterTax = 0.75;
            double[] result= new double[numbers.Length];
            int index = 0; 
            foreach (double i in numbers)
            {
                result[index]= i*afterTax;
                index++;
            }
            return result;
        }

        public static string[] SentenceReturn(string sentence)
        {
            string[] NewSentence = sentence.Split(" ");
            string[] finalSenetence = new string[NewSentence.Length];
            int index = 0;
            foreach (string s in NewSentence)
            {
                if(s.Length > 4)
                {
                    finalSenetence[index] = s;
                    index++;
                }
            }
            return finalSenetence;
        }

        public static string[] CardDeck(string[] cardTypes, string[] cardNo)
        {
            int index = 0;
            string[] card = new string[(cardTypes.Length * cardNo.Length)];
            foreach(string s in cardTypes)
            {
                foreach(string s2 in cardNo)
                {
                    card[index] = s2 + "." + s; 
                    index ++;
                }
            }
            return card;
        }
        public static void PrintIntegerMatrix(int rows, int colums)
        {
            int[,] matrix = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Console.ReadLine();
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
        public static void PrintStringMatrix(string[,] strMatrix)
        {
            for (int i = 0; i < strMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < strMatrix.GetLength(0); j++)
                {
                    Console.Write(strMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void MatrixCreator(int rows, int colums)
        {
            int[,] matrix = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = i + j;
                }
            }
        }
        public static int[,] MatrixCreatorTask21(int rows, int colums)
        {
            int[,] matrix = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter {i+1} row values:");
                
                for (int j = 0; j < colums; j++)
                {

                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        //public static void MatrixCreatorWithArrays(int[] rows, int[] columns, int num)
        //{
        //    int[,] matrix = new int[rows[num], columns[num]];

        //    //Initialize the matrix with some values
        //    for (int i = 0; i < num-1; i++)
        //    {
        //        int k = 0;
        //        for (int j = 0; j < num-1; j++)
        //        {
        //            matrix[i, j] = columns[j];
        //        }
        //        k++;
        //        matrix[i, k] = rows[i];
        //    }
        //}
        public static void MatchFinderIntegerArray(int[,] matrix)
        {
            for(int i = 0;i < matrix.GetLength(0);i++)
            {
                for(int j = 0; j < matrix.GetLength(1);j++)
                {
                    int current = matrix[i, j];
                    int currentColIndex = j + 1;
                    for (int k = i; k < matrix.GetLength(0); k++)
                    {
                        for (int l = currentColIndex; l < matrix.GetLength(1); l++)
                        {
                            if (current == matrix[k,l])
                            {
                                Console.WriteLine(matrix[k,l]);
                            }
                        }
                        currentColIndex = 0;
                    }
                }
            }
        }
        public static void MatchFinderStringArray(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    string current = matrix[i, j];
                    int currentColIndex = j + 1;
                    for (int k = i; k < matrix.GetLength(0); k++)
                    {
                        for (int l = currentColIndex; l < matrix.GetLength(1); l++)
                        {
                            if (current == matrix[k, l])
                            {
                                Console.WriteLine(matrix[k, l]);
                            }
                        }
                        currentColIndex = 0;
                    }
                }
            }
        }

        public static int[,] MatrixMultiplication3x1(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[3,1];
            int a = 0;
            int b = 0;
                for (int j = 0; j < matrix1.GetLength(1); j++) //nulinis stulpelis
                {
                a = 0;
                    for (int k = 0; k< matrix2.GetLength(0); k++) //nulinis stulpelis
                    {
                        b = matrix1[j, k] * matrix2[k, 0];
                        a+=b;
                    }
                    result[j, 0] = a;
                }
            return result;
        }
        public static void MaximumMatrixValue(int[,] matrix, out int row, out int col, out int answer)
        {
            int[,] result = new int[matrix.GetLength(0),matrix.GetLength(1)];
            int firstValue = matrix[0, 0];
            row = 0;
            col = 0;
            for (int i = 0;  i < matrix.GetLength(0); i++)
            {
                for (int j = 0;j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= firstValue)
                    {
                        firstValue = matrix[i, j];
                        row = i;
                        col = j;
                        result[row, col] = matrix[i,j];
                    }
                }
            }
            answer = result[row, col];
        }
        public static void SimetricalMatrix(int[,] matrix321,out bool check,out int[,] result, out int[,] result2)
        {
            int k = 2;
            check = false;
            result = new int[matrix321.GetLength(0),matrix321.GetLength(1)];
            result2 = new int[matrix321.GetLength(0), matrix321.GetLength(1)];
            if (matrix321.GetLength(0)!=matrix321.GetLength(1))
            {
                check = false;
            }
            else if(matrix321.GetLength(0) == matrix321.GetLength(1))
            for (int i = 0; i < matrix321.GetLength(0); i++)
            {
                    for (int j = 0; j < matrix321.GetLength(0);j++)
                    {
                        result[j,i] = matrix321[j, k];
                        result2[i,j] = matrix321[k, j];
                    }
                    k--;                    
            }
        }
        public static void AnimalTablePriting(string[] header, int count)
        {
            string[,] animals = new string[count + 1, header.Length];
            foreach (var i in header)
            {
                Console.Write(i.PadRight(12));
            }
            Console.WriteLine();
            for (int l = 0; l < header.Length; l++)
            {
                animals[0, l] = header[l];
            }
            for (int i = 1; i <= count; i++)
            {

                for (int j = 0; j < header.Length; j++)
                {
                    animals[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < animals.GetLength(0); i++)
            {
                for (int j = 0; j < animals.GetLength(1); j++)
                {
                    Console.Write(animals[i, j].PadRight(15));
                }
                Console.WriteLine();
            }
        }
        public static void PrintingPlusSpace(char[,] symbols)
        {
            for (int i = 0;i< symbols.GetLength(0); i++)
            {
                for(int j = 0;j<symbols.GetLength(1);j++)
                {
                    if ((i==0 || i==3) && (j==0 || j==3))
                    {
                        symbols[i, j] = ' ';
                    }
                    else if ((i != 0 || i != 3) && (j != 0 || j != 3))
                    {
                        symbols[i, j] = '*';                        
                    }
                }
            }
            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                for (int j = 0; j < symbols.GetLength(1); j++)
                {
                    Console.Write(symbols[i,j]);
                }
                Console.WriteLine();
            }
        }


    }
}