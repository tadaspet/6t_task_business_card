namespace Task322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal= new Animal("Kola");
            Console.WriteLine($"{animal.AnimalName} makes sound {animal.MakeSound()}");

            Dog newDog = new Dog("Sargis");
            Console.WriteLine($"{newDog.AnimalName} makes sound {newDog.MakeSound()}");
        }
    }
}