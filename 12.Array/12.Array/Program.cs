using System.Text;

namespace _12.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 0 
            ////emty int Array has only 0 values
            ////empty string Array has values of "null"
            //int[] emtyArray =new int[10];
            //Console.WriteLine(emtyArray[0]);
            //Console.WriteLine(emtyArray[1]);
            //Console.WriteLine(emtyArray[6]);
            #endregion

            #region Example 1
            ////Array index starts from 0
            ////Array can provide indexed values
            //int[] arrayWithInitialValues = { 1, 2, 3, 4, 5, 6, 100 };
            //Console.WriteLine(arrayWithInitialValues[0]);
            //Console.WriteLine(arrayWithInitialValues[1]);
            //Console.WriteLine(arrayWithInitialValues[6]);
            #endregion

            #region Example 2
            //Array index can be set to desired values
            //int[] arrayWithInitialValues2 = { 1, 2, 3, 4, 5, 6, 100 };
            //arrayWithInitialValues2[0] = 5;
            //arrayWithInitialValues2[1] = 6;
            //arrayWithInitialValues2[2] = 7;
            //Console.WriteLine(arrayWithInitialValues2[0]);
            //Console.WriteLine(arrayWithInitialValues2[1]);
            //Console.WriteLine(arrayWithInitialValues2[2]);
            #endregion

            #region Hello Array
            //string[] Hello = new string[3];
            //for (int i = 0; i < Hello.Length; i++) 
            //{
            //    Console.WriteLine("Iveskite pasisveikinima kita kalba:");
            //    Hello[i] = Console.ReadLine();
            //}

            //Console.WriteLine("----------------------");
            //for (int i = 0; i < Hello.Length; i++)
            //{
            //    Console.WriteLine(Hello[i]);
            //}
            #endregion

            #region
            //int[] intArray = new int[10];
            //for (int index = 0; index < intArray.Length; index++)
            //{
            //    intArray[index] = index * index;
            //}
            //for (int index = 0;index < intArray.Length;index++)
            //{
            //    Console.WriteLine(intArray[index]);
            //}
            #endregion

            #region Last example
            //string sentece = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            //char[] chars = sentece.ToCharArray();
            //for (int i = 0; i < chars.Length; i+=2)
            //{
            //    chars[i] = char.ToUpper(chars[i]);
            //}
            //Console.WriteLine(new string(chars));
            #endregion

            #region Lecturer exmaple
            ////Name amount determined by user input
            //Console.WriteLine("kiek vaiku turite?");
            //int childrenAmount = Convert.ToInt32(Console.ReadLine());
            //string[] childrenNames = new string[childrenAmount];

            //for (int i = 0; i < childrenAmount; i++)
            //{
            //    Console.WriteLine($"Iveskite {i +1} vaiko varda:");
            //    childrenNames[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Jusu vaiku vardai");
            //foreach (var name in childrenNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region TASK 1.1
            //Console.WriteLine("----------Task 1.1----------");
            //Console.WriteLine("Eneter amount of numbers:");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //int[] multiplication = new int[amount];
            //int no11;
            //for (int i = 0; i < multiplication.Length; i++)
            //{
            //    Console.WriteLine($"Enter {i+1} number of {amount}:");
            //    no11 = Convert.ToInt32(Console.ReadLine());
            //    multiplication[i] = no11 * no11;
            //}
            //for (int i = 0; i < multiplication.Length; i++)
            //{
            //    Console.WriteLine(multiplication[i]);
            //}
            //Console.WriteLine("----------------------------");
            #endregion

            #region TASK 1.2
            //Console.WriteLine("----------Task 1.2----------");
            //Console.WriteLine("Eneter amount of numbers to sum:");
            //int amount12 = Convert.ToInt32(Console.ReadLine());
            //int[] Summary = new int[amount12];
            //int Sum = 0;
            //for (int i = 0; i < Summary.Length; i++)
            //{
            //    Console.WriteLine($"Enter number no {i + 1}:");
            //    Summary[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < Summary.Length; j++)
            //{
            //    Sum += Summary[j];
            //}
            //Console.WriteLine($"Overall sum : {Sum}");
            //Console.WriteLine("----------------------------");
            #endregion

            #region TASK 1.3 with metod
            //Console.WriteLine("----------Task 1.3----------");
            //Console.WriteLine("Enter amount of numbers to return greatest number:");
            //int amount13 = Convert.ToInt32(Console.ReadLine());
            //int[] biggestNo = new int[amount13];
            //for (int i = 0; i < biggestNo.Length; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1}:");
            //    biggestNo[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"The greatest number: {GreatestNumber(biggestNo)}");
            //Console.WriteLine("----------------------------");
            #endregion

            #region TASK 1.4 with metod
            //Console.WriteLine("----------Task 1.4----------");
            //Console.WriteLine("Enter amount of numbers int the sequence:");
            //int sequence = Convert.ToInt32(Console.ReadLine());
            //int[] sequenceArray = new int[sequence];
            //for (int i = 0; i < sequenceArray.Length; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1}:");
            //    sequenceArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"The reversed number sequence: {ReversedSequence(sequenceArray)}");
            //Console.WriteLine("----------------------------");
            #endregion

            #region TASK 2.1
            //Console.WriteLine("----------Task 2.1----------");
            //Console.WriteLine("'String Word'\n Enter a word:");
            //string word = Console.ReadLine();
            //Console.WriteLine($"Char Array:{ReturnSeparateWord(word)}");
            //Console.WriteLine("----------------------------");
            #endregion

            #region TASK 2.2
            //Console.WriteLine("----------Task 2.2----------");
            //Console.WriteLine("'String Sentence'\n Enter a sentence:");
            //string sentence = Console.ReadLine();
            //Console.WriteLine($"Char Array first letter:{StringSentence(sentence)}");
            //Console.WriteLine("----------------------------");
            #endregion

            #region TASK 2.3
            //Console.WriteLine("----------Task 2.3----------");
            //Console.WriteLine("'String Sentence'\n Enter a sentence:");
            //string sentence2 = Console.ReadLine();
            //Console.WriteLine($"Char Array last letter:{StringSentence2(sentence2)}");
            //Console.WriteLine("----------------------------");
            #endregion

            #region TAKS3.1
            //Console.WriteLine("----------Task 3.1----------");
            //Console.WriteLine("Enter amount of numbers int the sequence:");
            //int sequence31 = Convert.ToInt32(Console.ReadLine());
            //int[] sequenceArray31 = new int[sequence31];
            //for (int i = 0; i < sequenceArray31.Length; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1}:");
            //    sequenceArray31[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //DecresingBubbleSort(sequenceArray31, sequence31);
            //printArray(sequenceArray31, sequence31);
            //Console.WriteLine("----------------------------");
            #endregion

            #region TAKS3.2
            //Console.WriteLine("----------Task 3.2----------");
            //Console.WriteLine("Enter amount of numbers int the sequence:");
            //int sequence32 = Convert.ToInt32(Console.ReadLine());
            //int[] sequenceArray32 = new int[sequence32];
            //for (int i = 0; i < sequenceArray32.Length; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1}:");
            //    sequenceArray32[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //IncresingBubbleSort(sequenceArray32, sequence32);
            //printArray(sequenceArray32, sequence32);
            //Console.WriteLine("----------------------------");
            #endregion

            #region TASK3.3
            //Console.WriteLine("----------Task 3.3----------");
            //Console.WriteLine("Enter element to add to int Array:");
            //int sequence33 = Convert.ToInt32(Console.ReadLine());
            //int[] sequenceArray33 = {1, 55, 66, 7, 8 };
            //int[] newArray = ArrayIncreasement(sequenceArray33, sequence33);
            //printArray(newArray, sequenceArray33.Length+1);
            //Console.WriteLine("----------------------------");
            #endregion

            #region
            //Console.WriteLine("----------Task 3.4----------");
            //Console.WriteLine("Remove from int Array");
            //int[] sequenceArray33 = { 1, 55, 66, 7, 8 };
            //string strinArray = string.Join(",", sequenceArray33);
            //Console.WriteLine(strinArray);
            //Console.WriteLine("Enter element order number:");
            //int indexNo = Convert.ToInt32(Console.ReadLine());
            //int[] newArray = RemoveFromArray(sequenceArray33, indexNo);
            //printArray(newArray, sequenceArray33.Length - 1);
            //Console.WriteLine("----------------------------");
            #endregion

            #region Temperature use MATH.ABS || compare min max || define boundaries
            //int n = 5; // the number of temperatures to analyse
            //string[] inputs = { "1", "-2", "-8", "4", "5" };
            //int[] postiveN = new int[n];
            //int posSmallest = postiveN[0];
            //int[] negativeN = new int[n];
            //int negSmallest = negativeN[0];
            //for (int i = 0; i < n; i++)
            //{
            //    int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
            //    for (i = 0; i < n; i++)
            //    {
            //        if (t > 0)
            //        {
            //            postiveN[i] = t;
            //        }
            //        if (t < 0)
            //        {
            //            negativeN[i] = t;
            //        }
            //    }
            //    for (i = 1; i < postiveN.Length; i++) //smallest postive
            //    {
            //        if (postiveN[i] > posSmallest)
            //        {
            //            posSmallest = postiveN[i];
            //        }
            //    }

            //    for (i = 1; i < negativeN.Length; i++) //biggest 
            //    {
            //        if (negativeN[i] > negSmallest)
            //        {
            //            negSmallest = negativeN[i] * -1;
            //        }
            //    }

            //    if (posSmallest >= negSmallest)
            //    {
            //        Console.WriteLine(posSmallest);
            //    }
            //    else if (posSmallest < negSmallest)
            //    {
            //        Console.WriteLine(negSmallest);
            //    }
            //    else if (n >= 0)
            //    {
            //        Console.WriteLine("0");
            //    }


            //    Console.WriteLine("result");
            //}

            int n = 5;
            string[] inputs = { "42", "-5", "12", "21", "5", "24" };
            if (n >= 0 && n < 10000)
            {
                int threshold=0;
                int start = Math.Abs(int.Parse(inputs[0]));
                for (int i = 0; i < n; i++)
                {
                    int t = int.Parse(inputs[i]);
                    int check = Math.Abs(t);
                    if (check < start || (i==0 && check <= start))
                    {
                            threshold = t;
                    }
                }
                Console.WriteLine(threshold);
            }
            else if (n == 0)
            {
                Console.WriteLine("0");
            }





            #endregion

        }
        public static int GreatestNumber(params int[] biggestNo)
        {
            int num = biggestNo[0];
            for (int i = 1;i < biggestNo.Length; i++)
            {
                if ((biggestNo[i] > biggestNo[i-1]) && biggestNo[i] > num)
                {
                    num = biggestNo[i];
                }
                else if (num > biggestNo[i])
                {
                    num = biggestNo[0]; 
                }
            }
            return num;
        }
        public static string ReversedSequence(params int[] sequenceArray)
        {
            StringBuilder reversedText= new StringBuilder();
            for (int i = sequenceArray.Length-1; i >=0 ;i--)
            {
                reversedText.Append(sequenceArray[i]);
            }
            return reversedText.ToString();
        }
        public static string ReturnSeparateWord(string word)
        {
            char[] SeparateCharacters = word.ToCharArray();
            StringBuilder NewWord = new StringBuilder();
            NewWord.Append("{");
            for (int i = 0; i < SeparateCharacters.Length; i++)
            {
                NewWord.Append($"'{SeparateCharacters[i]}'");
                if (i < SeparateCharacters.Length - 1)
                {
                    NewWord.Append(",");
                }
            }
            NewWord.Append("}");
            return NewWord.ToString();
        }
        public static char StringSentence(string sentence)
        {
            char[] sentenceChar = sentence.ToArray();
            
            return sentenceChar[0];
        }
        public static char StringSentence2(string sentence2)
        {
            char[] sentenceChar = sentence2.ToArray();
            int last = sentenceChar.Length -1;
            return sentenceChar[last];
        }
        //public static string SortedArray(params int[] array)
        //{
        //    StringBuilder sorted = new StringBuilder();
        //    int biggest=0;
        //    int[] smaller=new int[array.Length];

        //    for (int i = 0; i < array.Length-1; i++)
        //    {
        //        if (array[i] > array[0])
        //        {
        //            biggest = smaller[0];
        //        }
        //        for (int j = 0; j < array.Length ;j++)
        //        {
        //            if (smaller[j] > array[i])
        //            {
        //                smaller[0+i] = smaller[j];
        //            }
        //        }
        //    }
        //    //sorted.Append(biggest);
            //return sorted.ToString();
        //}
        public static void DecresingBubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            //bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                //swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        //swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                //if (swapped == false)
                //    break;
            }
        }
        static void printArray(int[] arr, int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void IncresingBubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static int[] ArrayIncreasement(int[] array, int add)
        {
            int i;
            int length= array.Length;
            int[] newArray = new int[length+1];
            for (i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = add;
            return newArray;
        }
        public static int[] RemoveFromArray(int[] array,int remove)
        {
            int i, j;
            remove = remove - 1;
            int[] newArray = new int[array.Length-1];
            for (i=0; i < remove; i++)
            {
                newArray[i] = array[i];
            }
            for (j=i+1; j< array.Length; j++ )
            {
                newArray[j-1] = array[j];
            }
            return newArray;
        }

    }
}






       