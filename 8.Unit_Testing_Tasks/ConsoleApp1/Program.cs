namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static void Main()
        {
            Console.WriteLine("=====TASK 8.2=====");
            Console.WriteLine("Lygiu skaiciu tikrinimas, iveskite pirma skaiciu:");
            string inPutNo1 = Console.ReadLine();
            Console.WriteLine("Iveskite 2 skaiciu:");
            string inPutNo2 = Console.ReadLine();
            Console.WriteLine("Iveskite 3 skaiciu:");
            string inPutNo3 = Console.ReadLine();
            int no1 = Convert.ToInt32(inPutNo1);
            int no2 = Convert.ToInt32(inPutNo2);
            int no3 = Convert.ToInt32(inPutNo3);
            bool equal3 = ((no1 == no2) && (no1 == no3) && (no2 == no3));
            bool equal2 = ((no1 == no2) || (no1 == no3) || (no2 == no3));
            if (equal3)
            {
                Console.WriteLine("Visi skaiciai lygus");
            }
            else if (equal2)
            {
                Console.WriteLine("Du skaiciai lygus");
            }
            else
            {
                Console.WriteLine("Ne vienas skaicius nera lygus");
            }
        }
    }
}