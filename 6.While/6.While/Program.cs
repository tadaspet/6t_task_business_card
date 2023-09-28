public static class While
{
    public static void Main(string[] args)
    {
    }

        #region examples
        //Console.WriteLine("======WHILE======");
        //double i = -5;
        //while (i <=5)
        //{
        //    Console.WriteLine(i);
        //    i++; // i = i+1
        //}
        #endregion

        #region examples 2 
        //Console.WriteLine("======WHILE ex: 2======");
        //double o = 1;
        //string result = " ";
        //while (o <= 5)
        //{
        //    Console.WriteLine("Iveskite teksta:");
        //    string input = Console.ReadLine();
        //    result += " " + input;
        //    o++;
        //}
        //Console.WriteLine(result);
        #endregion

        #region example 3
        //Console.WriteLine("Atspekite skaiciu:");
        //string userInput = "";
        //string secretNo = "3";
        //while (userInput != secretNo)
        //{
        //    Console.WriteLine("Spekite skaiciu:");
        //    userInput = Console.ReadLine();
        //}
        //Console.WriteLine("Sveikiname, atspejote!");
        #endregion

        #region example 4
        //Console.WriteLine("Atspekite skaiciu is 3 bandymu:");
        //string userInput = "";
        //string secretNo = "4";
        //int attempts = 0;
        //bool CorrectGuess = false;

        //while (!CorrectGuess && attempts < 3 )
        //{
        //    Console.WriteLine("Spekite skaiciu:");
        //    userInput = Console.ReadLine();
        //    CorrectGuess = userInput == secretNo;
        //    attempts++;
        //    Console.WriteLine($"Spejate jau {attempts} kartus");
        //}
        //if (CorrectGuess)
        //{
        //    Console.WriteLine("Sveikiname, atspejote!");
        //}
        //else
        //{
        //    Console.WriteLine("Jums baigesi spejimu skaicius");
        //}
        #endregion

        #region example 5 WHILE IN WHILE
        //Console.WriteLine("Atspekite skaiciu is 3 bandymu:");
        //int i = 1;
        //int j = 1;

        //while ( i <= 3)
        //{
        //    Console.WriteLine($"Outer loop {i}");
        //    while ( j <= 3 )
        //    {
        //        Console.WriteLine($"Inner loop {j}");
        //        j++;
        //    }
        //    i++;
        //    j=1;
        //}
        #endregion



        #region No 1.1
        //Console.WriteLine("======No1.2======");
        //double i = 1;
        //int test = 6;
        //while (i < test)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}
        //int i2 = 1;
        //Console.WriteLine("Atgal");
        //while (i2 <= 5)
        //{
        //    Console.WriteLine(test - i2);
        //    i2++;
        //}
        #endregion

        #region No 1.2
        //Console.WriteLine("======No1.2======");
        //double i = 1;
        //double test2 = 2;
        //while (i <= 5)
        //{
        //    Console.WriteLine(test2);
        //    test2 = test2 + 2;
        //    i++;
        //}
        //Console.WriteLine("Atgal nelyginiai skaiciai");
        //double i2 = 1;
        //double test3 = 9;
        //while (i2 <= 5)
        //{
        //    Console.WriteLine(test3);
        //    test3 = test3 - 2;
        //    i2++;
        //}
        #endregion

        #region No 1.3
        //Console.WriteLine("======No1.3======");
        //Console.WriteLine("Iveskite skaiciu:");
        //double no = 101;
        //while (no > 100)
        //{
        //    double input = Convert.ToDouble(Console.ReadLine());
        //    no = input;
        //}
        //Console.WriteLine("Ivestas skaicius mazesnis uz 100");
        //Console.WriteLine("Iveskite skaiciu:");
        //double i2 = 1;
        //while (i2 > 0)
        //{
        //    double input2 = Convert.ToDouble(Console.ReadLine());
        //    i2 = input2;
        //}
        //Console.WriteLine("Ivestas skaicius nera teigiamas");
        #endregion

        #region No 2.1
        //Console.WriteLine("======No2.1======");
        //Console.WriteLine("Iveskite teigiama skaiciu suskaiciuoti faktoriala:");
        //double faktorial = Convert.ToDouble(Console.ReadLine());
        //double cicle = 1;
        //double sumFinal = 1;
        //while (faktorial > 0)
        //{
        //    Console.WriteLine($"Ivestas skaicius {faktorial} > 0");

        //    while (cicle <= faktorial)
        //    {
        //        Console.WriteLine($"Sandauga {sumFinal} * {cicle},");
        //        sumFinal *= cicle;
        //        cicle++;
        //    }
        //    Console.WriteLine($"Skaiciaus {faktorial} faktorialas = {sumFinal}");
        //    cicle = faktorial + 1;
        //    Console.WriteLine("Iveskite dar viena skaiciu:");
        //    double check = Convert.ToDouble(Console.ReadLine());
        //    faktorial = check;
        //}
        //Console.WriteLine($"Ivestas skaicius {faktorial} nebuvo teigiamas");
        #endregion

        #region No 2.2
        //Console.WriteLine("======No2.1======");
        //Console.WriteLine("Iveskite skaiciu:");
        //string inPut22 = Console.ReadLine();
        //double check22 = Convert.ToDouble(inPut22);
        //char[] noArray = inPut22.ToCharArray();
        //bool postive = check22 > 0;
        //int count = inPut22.Length;
        //int sequence = 0;
        //if (postive)
        //{
        //    while (count-- > 0)
        //    {

        //        Console.WriteLine(noArray[sequence]);
        //        sequence++;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Skaicius nera teigimas");
        //}
        #endregion

        #region No 2.3
        //Console.WriteLine("======No2.3======");
        //Console.WriteLine("Iveskite skaiciu:");
        //double no23 = Convert.ToDouble(Console.ReadLine());
        //char star = '*';
        //int count23 = 1;
        //while (no23-- > 0)
        //{
        //    Console.WriteLine(new string(star,count23));
        //    count23++;
        //}
        #endregion

        #region No 3.1
        //Console.WriteLine("======No2.3======");
        //Console.WriteLine("Iveskite skaiciu:");
        //double no31 = Convert.ToDouble(Console.ReadLine());
        //while (no31<=0)
        //{
        //    Console.WriteLine($"Iveistas blogas skaicius: {no31}\nIveskite nauja skaiciu:");
        //    double no311 = Convert.ToDouble(Console.ReadLine());
        //    no31 = no311;
        //}
        //if (no31>0)
        //{
        //    Console.WriteLine($"Jusu skaicius {no31} yra didesnis uz nuli");
        //}
        #endregion

        #region No 3.2
        public static double NumberExponent(double rootNo, double superNo)
        {

            //Console.WriteLine("======No3.2======");
            //Console.WriteLine("Iveskite skaiciu kuri noretume pakelti laipsniu:");
            //double rootNo = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Iveskite skaiciaus laipsni:");
            //double superNo = Convert.ToDouble(Console.ReadLine());
            double sumPrint = 1;
            double tempSuper = superNo;
            while (tempSuper > 0)
            {
                sumPrint = sumPrint * rootNo;
                Console.WriteLine("Tarpine suma:" + sumPrint);
                tempSuper--;
            }
            Console.WriteLine(sumPrint);
            return sumPrint;
            #endregion
        }
        #region No 3.2.1
        public static bool NumberExponentCheck1(double rootNo, double superNo)
        {

        //Console.WriteLine("======No3.2======");
        //Console.WriteLine("Iveskite skaiciu kuri noretume pakelti laipsniu:");
        //double rootNo = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Iveskite skaiciaus laipsni:");
        //double superNo = Convert.ToDouble(Console.ReadLine());
        double sumPrint = 1;
        double tempSuper = superNo;
        while (tempSuper > 0)
        {
            sumPrint = sumPrint * rootNo;
            Console.WriteLine("Tarpine suma:" + sumPrint);
            tempSuper--;
        }
        Console.WriteLine(sumPrint);
        return (tempSuper == 0);
        }
    #endregion

    #region No 3.3
    //Console.WriteLine("======No3.3======");
    //Console.WriteLine("Iveskite skaiciu:");
    //string no33 = Console.ReadLine();
    //Console.WriteLine("Iveskite sugrupavimo kieki:");
    //string group33 = Console.ReadLine();
    //int numNo33 = Convert.ToInt32(no33);
    //int groupNo33 = Convert.ToInt32(group33);
    //bool check331 = int.TryParse(no33, out numNo33);
    //bool check332 = int.TryParse(group33, out groupNo33);
    //string final = " -> " + no33;
    //string test = "";
    //int cicle = 1;
    //if (check331 && check332)
    //{
    //    Console.WriteLine("jus ivedete skaicius!");
    //}
    //while (cicle <= groupNo33)
    //{
    //    test += final;
    //    Console.WriteLine(test);
    //    cicle++;
    //}
    //Console.WriteLine("Spausdinimas baigtas");
    #endregion

    #region No 4.1
    public static bool PositiveNumberCheck(int intNo41)
    {
        //Console.WriteLine("======No4.1======");
        //Console.WriteLine("Iveskite sveikaji skaiciu spausdinamu eiluciu kiekiui:");
        //string no41 = Console.ReadLine();
        //int intNo41 = Convert.ToInt32(no41);
        //Console.WriteLine("Iveskite sveikaji skaiciu nuo kurio pradeti spausdinima:");
        //int startNo = Convert.ToInt32(Console.ReadLine());
        int cicle = 1; // startNo;
        string free = "";
        while (intNo41 > 0)
        {
            free = Convert.ToString(cicle);
            Console.WriteLine(string.Concat(Enumerable.Repeat(free, cicle)));
            cicle++;
            intNo41--;
        }
        return (cicle > 1);
    }
    #endregion
    #region No 4.1.1
    public static double RowCount(int intNo41)
    {
        //Console.WriteLine("======No4.1======");
        //Console.WriteLine("Iveskite sveikaji skaiciu spausdinamu eiluciu kiekiui:");
        //string no41 = Console.ReadLine();
        //int intNo41 = Convert.ToInt32(no41);
        //Console.WriteLine("Iveskite sveikaji skaiciu nuo kurio pradeti spausdinima:");
        //int startNo = Convert.ToInt32(Console.ReadLine());
        int cicle = 1; // startNo;
        string free = "";
        while (intNo41 > 0)
        {
            free = Convert.ToString(cicle);
            Console.WriteLine(string.Concat(Enumerable.Repeat(free, cicle)));
            cicle++;
            intNo41--;
        }
        return (cicle);
    }
    #endregion

    #region No 4.2
    //Console.WriteLine("======No4.2======");
    //Console.WriteLine("Iveskite pinigu suma kuria norite isgryninti:");
    //int countNo = Convert.ToInt32(Console.ReadLine());
    //int countSum = countNo;
    //int div50 = 0;
    //int div20 = 0;
    //int div10 = 0;
    //while (countSum >= 50)
    //{
    //    countSum -= 50;
    //    div50++;
    //}
    //while (countSum >= 20)
    //{
    //    countSum -= 20;
    //    div20++;
    //}
    //while (countSum >= 10)
    //{
    //    countSum -= 10;
    //    div10++;
    //}
    //int cashLeft = countNo - ((div50 * 50) + (div20 * 20) + (div10 * 10));
    //Console.WriteLine($"Jus gausite {div50} - 50, {div20} - 20, {div10} - 10 kupiuras.\nNegrazinta - {cashLeft}.");
    #endregion

    #region No 5.1
    //Console.WriteLine("======No5.1======");
    //Console.WriteLine("Ivestus skaicius susumuosime, norint sustoti parasykite 'Baigti':");
    //double trueNo = 0;
    //double noCount;
    //bool noCheck;
    //string inPut51 = "";
    //bool finish;
    //do
    //{
    //    Console.Write("Jusu skaicius:");
    //    inPut51 = Console.ReadLine().ToLower();
    //    finish = inPut51 == "baigti";
    //    if (!finish)
    //    {
    //        noCheck = double.TryParse(inPut51, out noCount);

    //        if (noCheck)
    //        {
    //            Console.WriteLine("Iveskite sekanti skaiciu");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Neteisingas ivedimas.");
    //        }
    //        trueNo += noCount;
    //    }
    //} while (!finish);
    //Console.WriteLine("Skaiciu suma:" + trueNo);
    #endregion

    #region 5.2
    //Console.WriteLine("======No5.2======");
    //Console.WriteLine("Atspekite slaptazodi, spejimu skaicius nelimituotas:");
    //string pass52 = "123789";
    //string inPut52;
    //int count = 1;
    //do
    //{
    //    inPut52 = Console.ReadLine();
    //    if (inPut52 == pass52)
    //    {
    //        Console.WriteLine($"Just atspejote is {count} karto!!!");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Bandykite dar\nNepavykusiu bandymu skaicius {count}");
    //    }
    //    count++;
    //} while (inPut52 != pass52);
    #endregion

    #region No 5.3
    //Console.WriteLine("======No5.3======");
    //Console.WriteLine("Atspekite skaiciu nuo 1-100");
    //Random random = new Random();
    //int randNo53 = random.Next(1, 100);
    //int inPut53;
    //do
    //{
    //    inPut53 = Convert.ToInt32(Console.ReadLine());
    //    if (randNo53 > inPut53)
    //    {
    //        Console.WriteLine($"Skaicius - yra mazesnis uz spejama.");
    //    }
    //    else if (randNo53 < inPut53)
    //    {
    //        Console.WriteLine($"Skaicius - yra didesnis uz spejama.");
    //    }
    //    else if ( randNo53 == inPut53)
    //    {
    //        Console.WriteLine($"Jusu atspejote skaiciu: {inPut53} !");
    //    }
    //} while (randNo53 != inPut53);
    #endregion
}
