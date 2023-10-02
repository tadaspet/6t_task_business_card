
namespace _04.Abstractions
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Class material
            //        var dog = new Dog(50, "Reksas", false);
            //        var cat = new Cat(5, "Miukse", true);

            //        var animals = new List<Animal>();
            //        animals.Add(cat);
            //        animals.Add(dog);

            ////        Console.WriteLine("Name: " + dog.Name + "\nWeight: " + dog.Weight + "\nService appliacable: " +
            ////            "" + dog.IsServiceDog + "\nNoise: ");
            ////        dog.MakeNoise();
            ////        Console.WriteLine("--------------");
            ////        Console.WriteLine("Name: " + cat.Name + "\nWeight: " + cat.Weight + "\nDomestic: " +
            ////"" + cat.IsDomestic + "\nNoise: ");
            ////        cat.MakeNoise();
            //        PrintAnimals(animals);
            #endregion

            #region Task 111 & 113
            //var triangle1 = new Triangle(4, 3);
            //var square1 = new Square(4, 3);
            //var triangle2 = new Triangle(5, 4);
            //var square2 = new Square(5, 4);
            //var triangle3 = new Triangle(3, 8);
            //var square3 = new Square(8, 3);

            //var geometryShapes = new List<GeometricShape> ();
            //geometryShapes.Add (triangle1);
            //geometryShapes.Add (triangle2);
            //geometryShapes.Add (triangle3);
            //geometryShapes.Add (square1);
            //geometryShapes.Add (square2);
            //geometryShapes.Add (square3);

            //PrintShapes (geometryShapes);

            #endregion

            #region Task 112 Same as class example

            #endregion

            #region 211
            DateOnly dateBus1 = new DateOnly (2018,3,3);
            DateOnly dateMotor1 = new DateOnly(2021, 7, 7);
            DateOnly dateTruck1 = new DateOnly(2010, 1, 1);
            var bus1 = new Bus(6, "Setra", dateBus1, 60);
            var motor1 = new Motorcycle(2, "Honda", dateMotor1 , true);
            var truck1 = new Truck(8, "Man", dateTruck1, 40);
            var vehicles = new List<Vehicle>();
            vehicles.Add(bus1);
            vehicles.Add(motor1);
            vehicles.Add(truck1);
            //PrintVechiles(vehicles);

            Human human = new Human("John Doe", 34, vehicles);

            human.CurrentVehicle();

            #endregion
        }
        public static void PrintVechiles(List<Vehicle> vehicles)
        {
            foreach (Vehicle v in vehicles)
            {
                v.GetVehicleInfo();
            }
        }
        public static void PrintShapes(List<GeometricShape> geometryShapes)
        {
            int count = 1;  
            foreach (var shape in geometryShapes)
            {
                Console.Write($"{count} Shape.");
                shape.GetPerimeter();
                Console.Write($"{count} Shape.");
                shape.GetArea();
                Console.WriteLine("----------------");
                count++;
            }
        }
        public static void PrintAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.MakeNoise();
                Console.WriteLine("============");
            }
        }
    }
}