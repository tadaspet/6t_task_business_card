using System;

namespace _9._Ref_and_out
{
    public static class RefAndOutTasks
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("-----Example REF No1-----");
            //int a = 100;
            //Console.WriteLine(a);
            //ChangeValue(ref a);
            //Console.WriteLine(a);
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Example REF No2-----");
            //int x = 0;
            //DoSomething(ref x);
            //Console.WriteLine(x);
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Task No1.1-----");
            //int x11 = 3;
            //Console.WriteLine($"First int number: {x11}");
            //Swap(ref x11);
            //Console.WriteLine($"Swapped No: {x11}");
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Task No1.2-----");
            //int x12 = 8;
            //Console.WriteLine($"Start int number: {x12}");
            //IncrementByN(ref x12);
            //Console.WriteLine($"Increment by itself result: {x12}");
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Task No1.3-----");
            //string text13 = "  myName  ";
            //Console.WriteLine($"Starting text:{text13}.");
            //TrimAndCapitalize(ref text13);
            //Console.WriteLine($"Increment by itself result:{text13}.");
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Example OUT No1-----");
            //GetDimensions(out int width, out int height);
            //Console.WriteLine($"Plotis: {width}, ilgis: {height}");
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Task No2.1-----");
            //string name21;
            //string name22;
            //GetUserData(out string name211, out string name221);
            //Console.WriteLine($"Your name {name211} {name221}");
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Task No2.2-----");
            //Console.WriteLine("Enter Number:");
            //WhileCicle22(out double inPutNo22, out string  numberString, out bool check);
            //Console.WriteLine($"Program has ended because:\n{inPutNo22} is greater than - 100\n{check} - conversion.");
            //Console.WriteLine("--------END---------\n");

            //Console.WriteLine("-----Task No2.3-----");
            //Console.WriteLine("Enter two numbers:");
            //Divide23(out double OutPutNo231, out double OutPutNo232, out bool result23);
            //Console.WriteLine($"Calculations will be valid? - {result23}\nDivision result: {OutPutNo231}\nReminder result: {OutPutNo232}");
            //Console.WriteLine("--------END---------\n");


        }
        static void ChangeValue(ref int x)
        {
            x = 200;
        }
        static void DoSomething(ref int x)
        {
            x += 1;
        }
        public static int Swap(ref int x11)
        {
            x11 = 23;
            return x11;
        }
        public static int IncrementByN (ref int incNo)
        {
            incNo += incNo;
            return incNo;
        }
        public static string TrimAndCapitalize (ref string text13)
        {
            string text13Temp = text13.Trim();
            text13 = char.ToUpper(text13Temp[0])+text13Temp.Substring(1);
            return text13;
        }
        public static int GetDimensions(out int width, out int height)
        {
            width = 1024;
            height = 768;
            return width + height;
        }
        public static string GetUserData(out string name211, out string name221)
        {
            //Console.WriteLine("Type Your Name:");
            //name211 = Console.ReadLine();
            //Console.WriteLine("Type Your Surname:");
            //name221 = Console.ReadLine();
            name211 = "Vardas";
            name221 = "Pavarde";
            return name211;
        }
        public static double WhileCicle22(out double inPutNo22, out string numberString, out bool check)
        {
            inPutNo22 = 1;
            numberString = "99";
            check = true;
            while (inPutNo22 <= 100)
            {
                check = double.TryParse(numberString, out inPutNo22);
                if (!check)
                {
                    Console.WriteLine("Inavlid Character, pleas Re-enter number:");
                }
                else if (check)
                {
                    Console.WriteLine($"Conversation of number: {check}\nNumber was: {inPutNo22}");
                    if (inPutNo22 <= 100)
                    {
                        Console.WriteLine("Please try another Number:");
                    }
                    inPutNo22+=10;
                }
            };
            return inPutNo22;
        }
        public static double Divide23(out string text1, out string text2, out double OutPutNo231,out double OutPutNo232, out bool result23)
        {
            result23 = false;
            OutPutNo231 = 0;
            OutPutNo232 = 0;
            double inPutNo231;
            double inPutNo232;
            text1 = "8";
            text2 = "7";
            bool check231 = double.TryParse(text1, out inPutNo231);
            bool check232 = double.TryParse(text2, out inPutNo232);
            if (check231 && check232)
            {
                //Console.WriteLine("Inputed characters are numbers.");
                if (inPutNo231 != 0 && inPutNo232 != 0)
                {
                    OutPutNo231 = Math.Round(inPutNo231 / inPutNo232, 2);
                    OutPutNo232 = inPutNo231 % inPutNo232;
                    result23 = true;
                }
                else if(inPutNo231 == 0 || inPutNo232 == 0  )
                {
                    result23 = false;
                }
            }
            return OutPutNo232;
        }
        
    }
}