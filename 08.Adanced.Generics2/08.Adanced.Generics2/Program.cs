namespace _08.Adanced.Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task111
            Console.WriteLine("------------------");
            var task1 = new Task111<string, string>();
            task1.ChangeFirstValue("Muzika");
            task1.ChangeSecondValue("Teatras");
            task1.ShowFirstValue();
            task1.ShowSecondValue();
            Console.WriteLine("Changed values:");
            task1.ChangeFirstValue("Skamba");
            task1.ChangeSecondValue("Vaidina");
            task1.ShowFirstValue();
            task1.ShowSecondValue();
            var task2 = new Task111<int, int>();
            task2.ChangeFirstValue(2023);
            task2.ChangeSecondValue(2050);
            task2.ShowFirstValue();
            task2.ShowSecondValue();

            Console.WriteLine("------------------");
            #endregion

            #region Task222
            var figure1 = new FourSideGeometricFigure("Rectangle",10,4);
            var generator1 = new Generator<double>();
            var generator2 = new Generator<string>();
            var generator3 = new Generator<FourSideGeometricFigure>();
            Console.WriteLine(figure1);
            Console.WriteLine(figure1.GetArea());
            generator1.Show(figure1.GetArea());
            generator3.Show(figure1);

            #endregion

            #region 333
            //Console.WriteLine("---------------");
            //var newType = new Type<double, string>(13.10, "String");
            //newType.GetType(newType.Input1);
            //newType.GetType(newType.Input2);
            //newType.GetType(newType);

            #endregion

            #region 444
            Console.WriteLine("---------------");
            var newgame = new GameLeague<int, int>();
            newgame.AddTeam(1, 13);
            newgame.AddTeam(1, 12);
            newgame.PrintTeams();


            #endregion
        }
    }
}