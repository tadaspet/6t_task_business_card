namespace _8.Unit_Testing_Tasks
{
        public class Kalkuliuok
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Skaiciuotuvo programa.");
                Console.WriteLine("Iveskite Pirma skaiciu, pasirinkite Veiksma, iveskite Antra skaiciu");
                string[] operation = { "+", "-", "*", "/", "V", "^" };
                string[] calOper = { "1.Sudeties: +", "2.Atimtis: -", "3.Daugyba: *", "4.Dalybas: /", "5.Saknis: V", "6.Kelimas laipsniu: ^", "7.Skaiciavimo pabaiga: q" };
                Console.WriteLine($"{calOper[0]}\n{calOper[1]}\n{calOper[2]}\n{calOper[3]}\n{calOper[4]}\n{calOper[5]}");
                string inPut1 = "";
                string inPut2 = "";
                string inPutOper = "";
                double value1;
                double value2;
                bool operCheck;
                do
                {
                    inPut1 = Console.ReadLine().ToLower();
                    bool val1 = double.TryParse(inPut1, out value1);
                    if (inPut1 == "q")
                    {
                    Console.WriteLine("Skaiciavimo pabaiga");
                    break;
                    }
                    inPutOper = Console.ReadLine().ToLower();
                    operCheck = Array.Exists(operation, s => s == inPutOper);
                    if (inPutOper == "q")
                    {
                    Console.WriteLine("Skaiciavimo pabaiga");
                    break;
                    }
                    inPut2 = Console.ReadLine().ToLower();
                    bool val2 = double.TryParse(inPut2, out value2);
                    if (inPut2 == "q")
                    {
                    Console.WriteLine("Skaiciavimo pabaiga");
                    break;
                    }
                    if (!operCheck || !val1 || !val2)
                    {
                        Console.WriteLine("Viena is ivesciu neteisinga, kartokite:");
                    }
                    else if (operCheck && val1 && val2)
                    {
                        switch (inPutOper)
                        {
                            case "+":
                                Console.WriteLine($"Atsakymas: {AdditionMath(value1, value2)}");
                                break;
                            case "-":
                                Console.WriteLine($"Atsakymas: {SubtractionMath(value1, value2)}");
                                break;
                            case "*":
                                Console.WriteLine($"Atsakymas: {MultiplicationMath(value1, value2)}");
                                break;
                            case "/":
                                Console.WriteLine($"Atsakymas: {DivisionMath(value1, value2)}");
                                break;
                            case "v":
                                Console.WriteLine($"Atsakymas: {RootMath(value1, value2)}");
                                break;
                            case "^":
                                Console.WriteLine($"Atsakymas: {ExponentionalMath(value1, value2)}");
                                break;
                        }
                        Console.WriteLine("Skaiciuokite is naujo:");
                    }
                } while (true);
            }
            public static double AdditionMath(double no1, double no2)
            {

                return Math.Round((no1 + no2),9);
            }
            public static double SubtractionMath(double no1, double no2)
            {

                return Math.Round((no1 - no2), 9);
            }
            public static double MultiplicationMath(double no1, double no2)
            {

                return Math.Round((no1 * no2), 9);
            }
            public static double DivisionMath(double no1, double no2)
            {

                return Math.Round((no1 / no2), 9);
            }
            public static double RootMath(double no1, double no2)
            {

                return Math.Round(Math.Pow(no1, 1 / no2), 9);
            }
            public static double ExponentionalMath(double no1, double no2)
            {

                return Math.Round(Math.Pow(no1,no2), 9);
            }
        }
}