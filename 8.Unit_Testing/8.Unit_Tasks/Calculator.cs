using System.Threading.Channels;

namespace _8.Unit_Tasks
{
    public class Kalkuliuok
    {
        static void Calculator(string[] intro)
        {
            Console.WriteLine("Skaiciuotuvo programa.");
            Console.WriteLine("Iveskite du skaicius skirtingose eilutese");
            Console.WriteLine("Po to iveskite simboli atliekamam veiksmu");
            double no1 = Convert.ToDouble(Console.ReadLine());
            double no2 = Convert.ToDouble(Console.ReadLine());
            string[] calOper = { "1.Sudeties simbolis: +", "2.Atimties simbolis: -", "3.Daugyba: *", "4.Dalybas: /", "5.Saknis: ^^", "6.Kelimas laipsniu: ^" };
            Console.WriteLine($"{calOper[0]}\n{calOper[1]}\n{calOper[2]}\n{calOper[3]}\n{calOper[4]}\n{calOper[5]}");

        }
        static void MathActions(string[] mathSelection) 
        {
            string[] calulations = { "1.Sudeties simbolis: +", "2.Atimties simbolis: -", "3.Daugyba: *", "4.Dalybas: /","5.Saknis: ^^","6.Kelimas laipsniu: ^" };
        }
        
    }
}