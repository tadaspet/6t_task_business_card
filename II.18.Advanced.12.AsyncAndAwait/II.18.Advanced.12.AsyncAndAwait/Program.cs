using System.Diagnostics;

namespace II._18.Advanced._12.AsyncAndAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, Async!");
            //DoingHardWork().GetAwaiter().GetResult(); /////////////////////////////////////////////////////////////////////

            //Task work = DoingHardWork();
            //while (true)
            //{
            //    Console.Write(".");
            //    if (work.IsCompleted)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Work is completely done.");
            //        break;
            //    }
            //    Thread.Sleep(500);
            //}

            //DoingHardWork_WithMistake(); //nesulauksime klaidos, nes tai yra void metodas
            

            /*
            User story:
            I want to be able to order Food in a Bar.
            It should be possible to order mutilple Dishes at once.
            I would like to have a repeat of what was ordered.
            Food should be prepared in the Bar Kitchen by given Order.
            */

            Bar bar = new Bar();

            Stopwatch sw;

            sw = Stopwatch.StartNew();
            var uzsakymoLapas = new List<Meal>
            {
                new Tea(),
                new FryedEggs(3),
                new Toast(slices: 2, jam: EJamType.Melynes),
                new Toast(2, 0)
            };
            Console.WriteLine(string.Join(", ", uzsakymoLapas.Select(meal => meal.Title)));
            await bar.Kitchen.PrepareImitation(uzsakymoLapas);

            Console.WriteLine($"Imitacija truko: {sw.ElapsedMilliseconds*0.001} ");


            Console.WriteLine("\n\n");

            sw = Stopwatch.StartNew();
            await bar.Kitchen.Prepare(new List<Meal>
            {
                new Tea(),
                new FryedEggs(3),
                //new Toast(slices: 2, jam: EJamType.Melynes),
                new Toast(2,0)
            });
            Console.WriteLine($"Asinchoroans truko: {sw.ElapsedMilliseconds*0.001} ");












































            var fileService = new FileService();
            var content = await fileService.ReadTextFromFileAsync();
            //Console.WriteLine(content);

            while (true)
            {
                Console.Write("*");
                Thread.Sleep(500);
                if(content.Length > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(content);
                    break;
                }
            }
            var content2 = fileService.ReadTextFromFileAsync();
            //Console.WriteLine(content);

            while (true)
            {
                Console.Write("*");
                Thread.Sleep(500);
                if (content2.IsCompleted)
                {
                    Console.WriteLine();
                    Console.WriteLine(content2.Result);
                    break;
                }
            }
        }
        public static async Task DoingHardWork()
        {
            //Thread.Sleep(5000);
            await Task.Delay(5000);
            Console.WriteLine("Hard work is finished.");
        }
        public static async void DoingHardWork_WithMistake()
        {
            await Task.Delay(5000);
            Console.WriteLine("Hard work is finished.");
            var a = int.Parse("aaaaaaaa");
        }
    }
}

