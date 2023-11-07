namespace II._18.Advanced._12.AsyncAndAwait
{
    public abstract class Meal
    {
        public abstract string Title { get; }
        public virtual Task<Meal> Prepare()
        {
            throw new NotImplementedException();
        }
    }
    public class Tea : Meal
    {
        public override string Title => "Arbata";
        public override async Task<Meal> Prepare()
        {
            Console.WriteLine("+(arbata) Pilame vandeni i arbatinuka");
            await Task.Delay(1000);
            Console.WriteLine("+(arbata) verdame vandeni");
            await Task.Delay(1000);
            Console.WriteLine("+(arbata) pripalame puoduka");
            await Task.Delay(1000);
            Console.WriteLine("DING! arbata paruosta");
            return new Tea();
        }
    }

    public class FryedEggs : Meal
    {
        private int _eggsCount;
        public FryedEggs(int eggsCount)
        {
            _eggsCount = eggsCount;
        }
        public override string Title => "Kiausiniene";
        public override async Task<Meal> Prepare()
        {
            Console.WriteLine($"+(Kiausiniene) Musame {_eggsCount} kiausinius");
            await Task.Delay(1000);
            Console.WriteLine("+(Kiausiniene) plakame");
            await Task.Delay(1000);
            Console.WriteLine("+(Kiausiniene) supilame i keptuve");
            await Task.Delay(1000);
            Console.WriteLine("+(Kiausiniene) kepame keptuveje");
            await Task.Delay(1000);
            Console.WriteLine("+(Kiausiniene) dedame i lekste");
            await Task.Delay(1000);
            Console.WriteLine("DING! Kiausiniene paruosta");
            return new Tea();
        }
    }

    public class Toast : Meal
    {
        private readonly int _slices;
        private readonly EJamType _jam;
        public Toast (int slices, EJamType jam)
        {
            _slices = slices;   
            _jam = jam;
        }
        public override string Title => "Tostas";
        public override async Task<Meal> Prepare()
        {
            await KeptiDuona();
            await TeptiSviesta();
            await TeptiUogiene();
            Console.WriteLine("DING! tostas su uogiene paruostas");
            return new Toast(_slices, _jam);
        }
        private async Task KeptiDuona()
        {
            for (int slice = 0; slice < _slices; slice++)
            {
                Console.WriteLine($"+(toste) dedame {_slices } riekes duonos i toster");
                Console.WriteLine($"+(toste) preadeda kepti");
                await Task.Delay(1000);
                Console.WriteLine("+(toste) isimama duona is tosterio");
            }
        }
        private async Task TeptiSviesta()
        {
            Console.WriteLine($"+++ Tepame sviesta");
            await Task.Delay(1000);
        }
        private async Task TeptiUogiene()
        {
            Console.WriteLine($"+++ Tepame {_jam} uogiene");
            await Task.Delay(1000);
        }

    }
    public enum EJamType
    {
        Melynes,
        Braskes
    }
}