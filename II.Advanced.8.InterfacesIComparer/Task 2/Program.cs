namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bmwCar = new BmwCar(false, "BMW-7", 50);
            var bmwCar2 = new BmwCar(true, "BMW-X5", 60);
            var bmwCar3 = new BmwCar(true, "BMW-3", 0);
            var audiCar = new AudiCar(false, "AUDI-A6", 20);
            //var audiCar2 = new AudiCar(true, "AUDI-Q7", 80);
            var audiCar2 = new AudiCar(true, "AUDI-Q7", 0);
            var audiCar3 = new AudiCar(true, "AUDI-80", 50);



            Console.WriteLine(bmwCar.Model);
            bmwCar.Drive();
            bmwCar.Refuel(50);

            //Console.WriteLine("\n"+audiCar.Model);
            //audiCar.Drive();
            //audiCar.Refuel(10);

            List<BmwCar> bmwList= new List<BmwCar>(){ bmwCar, bmwCar2, null, bmwCar3, null };
            List<AudiCar> audiList = new List<AudiCar>() { audiCar, audiCar2, audiCar3 };

            bmwList.Sort(new CarComparer());
            Console.WriteLine("\n");
            foreach (var car in bmwList)
            {
                if (car != null)
                {
                    Console.WriteLine(car.Model + " " + car.Fuel);
                }
                else { Console.WriteLine("null"); }
                
            }

            //bmwList.ForEach(x => Console.WriteLine($"Car {x.Model} has Xdrive:{x.IsXDrive} \t Fuel: {x.Fuel}"));
            //Console.WriteLine("\nAudi cars:\n");
            //audiList.ForEach(x=> x.Refuel(20));
            //Console.WriteLine();
            //audiList.Sort(new CarComparer());
            //foreach (var car in bmwList)
            //{
            //    Console.WriteLine(car.Model + " " + car.Fuel);
            //}




        }
    }
}