namespace _8.Unit_Testing_Tasks;

    public class Conditionals_IF
    {
        public static void Main(string[] args)
        {
        }
        public static string NumberIsDividingBy2or5(int inputNo3)
        {
            int evenNo2 = inputNo3 % 2;
            int fiveNo2 = inputNo3 % 5;
            if (evenNo2 == 0)
                return "Number is dividing by 2";
            else if (fiveNo2 == 0)
                return "Number is divinding by 5";
            else
                return "Number is not dividing by 2 or 5";
        }
        public static string TemperatureAnswer(int inputTemp)
        {
            if (inputTemp < 0)
            {
                return "Temperature is VERY COLD";
            }
            else if (inputTemp <= 20)
            {
            return "Temperature is CHILL";
            }
            else
            {
            return "Temperature is HOT";
            }
        }
        public static string CheckNumbersAreEqual(int no1, int no2, int no3)
        {
            bool equal3 = ((no1 == no2) && (no1 == no3) && (no2 == no3));
            bool equal2 = ((no1 == no2 && no3!=no1) || (no1 == no3 && no2 != no1) || (no2 == no3 && no2 !=no3));
            if (equal3)
            {
                return "Visi skaiciai lygus";
            }
            else if (equal2)
            {
                return "Du skaiciai lygus";
            }
            else
            {
                return "Ne vienas skaicius nera lygus";
            }
        }
    }
