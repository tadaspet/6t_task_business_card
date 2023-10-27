using System.Threading.Channels;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car
                {
                    Model = "BMW",
                    Fuel = 40,
                },
                new Car
                {
                    Model = "AUDI",
                    Fuel = 0,
                },
                new Car
                {
                    Model = "MERCEDES-BENZ",
                    Fuel = 12,
                },
            };
            Console.WriteLine("Can be cars driven any further?");
            cars.ForEach(car => car.Drive());
            Console.WriteLine("\n-----------\n");

            Console.WriteLine("Can cars can be refueled by positive amount?");
            cars.ForEach(cars => cars.Refuel(10));

            Console.WriteLine("\n-----------\n");
            //Console.WriteLine("Will fuel amount will not reach over tank limit?");
            //List<Car> tankSize = cars.Where(x => x.Fuel < 70).ToList();
            //tankSize.ForEach(car => Console.WriteLine($"{car.Model} can be filled by: {car.Fuel}"));
            //Console.WriteLine("\n-----------\n");

        }
    }
}