namespace HorseGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            int[] horsePower = new int[int.MaxValue];
            //for (int i = 0; i < N; i++)
            //{
            //    int pi = int.Parse(Console.ReadLine());
            //      if (pi < 1000000)
            //{
            //    horsePower.Add(pi);
            //}
            //    
            //}
            int[] powerDif = new int[int.MaxValue];
            for (int i = 0;i < horsePower.Length; i++)
            {
                for (int j = 0; j < horsePower.Length; j++)
                {
                    if(i != j && !powerDif.Contains(horsePower[i] - horsePower[j]))
                    {
                        powerDif[i]=(horsePower[i] - horsePower[j]);
                    }
                }
            }
            Array.Sort(powerDif);

            Console.WriteLine(powerDif.Where(x => x > 0).Min());

            //foreach (KeyValuePair<int, List<int>> a in powerDif)
            //{
            //    Console.WriteLine($"\n{a.Key}");
            //    foreach(int i in a.Value)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.WriteLine();
            //}

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

        }
    }
}


//static void Main(string[] args)
//{
//    int N = int.Parse(Console.ReadLine());
//    if (N > 1 || N < 100000)
//    {
//        List<int> horsePower = new List<int>();
//        for (int i = 0; i < N; i++)
//        {
//            int pi = int.Parse(Console.ReadLine());
//            if (pi < 1000000)
//            {
//                horsePower.Add(pi);
//            }
//        }

//        List<int> powerDif = new List<int>();
//        for (int i = 0; i < horsePower.Count; i++)
//        {
//            for (int j = 0; j < horsePower.Count; j++)
//            {
//                if (i != j && !powerDif.Contains(horsePower[i] - horsePower[j]))
//                {
//                    powerDif.Add(horsePower[i] - horsePower[j]);
//                }
//            }
//        }

//        List<int> sortedDiff = powerDif.OrderByDescending(x => x).ToList();

//        List<int> sortedList = new List<int>();
//        foreach (var pair in powerDif)
//        {
//            if (pair > 0)
//            {
//                sortedList.Add(pair);

//            }
//        }
//        int answer = sortedList.Min(x => x);
//        Console.WriteLine(answer);
//    }
//    else
//    {
//        Console.WriteLine(0);
//    }
//}