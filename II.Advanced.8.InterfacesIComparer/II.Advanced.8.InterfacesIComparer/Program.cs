namespace II.Advanced._8.InterfacesIComparer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            //dog.Talk();  
            //cat.Talk();

            List<IAnimals> list = new List<IAnimals> { dog, cat };

            list.ForEach(animal => animal.Talk());
        }
    }
}