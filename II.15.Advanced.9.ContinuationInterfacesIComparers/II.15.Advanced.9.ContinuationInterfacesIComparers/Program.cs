namespace II._15.Advanced._9.ContinuationInterfacesIComparers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog("Cozy", "Carrot", 5);
            var dog2 = new Dog("Bart", "Chicken", 4);

            var cat1 = new Cat("Fluff", "Sheba", 6);
            var cat2 = new Cat("Garfield", "Lazzania", 4);

            var bass1 = new Bass("Diver", "Earthworms", 10);
            var bass2 = new Bass("Chewwy", "Forage fish", 12);

            var carp1 = new Carp("Elephant", "Insects", 18);
            var carp2 = new Carp("Moustache", "Water plants", 16);

            Console.WriteLine("Animals eat:");
            List<IAnimal> animalList = new List<IAnimal>() 
            { dog1, dog2, cat1, cat2, bass1, bass2, carp1, carp2 };
            animalList.ForEach(animal => animal.Eat());
            
            Console.WriteLine("\nMammals children:");
            List<IMammal> mammals = new List<IMammal>() { dog1, dog2, cat1, cat2 };
            mammals.ForEach(mammal => mammal.GiveBirth());

            Console.WriteLine("\nFishes swim:");
            List<IFish> fishes = new List<IFish>() { bass1, bass2, carp1, carp2 };
            fishes.ForEach(fish => fish.Swim());

            List<Dog> dogList = new List<Dog>() { dog1, dog2 };
            List<Cat> catList = new List<Cat>() { cat1, cat2 };
            List<Bass> bassList = new List<Bass>() { bass1, bass2 };
            List<Carp> carpList = new List<Carp> { carp1, carp2 };

            Console.WriteLine("\nCompared DOG children quantity:");
            dogList.Sort(new ICompareDog());
            dogList.ForEach(dog => Console.WriteLine(dog.ChildrenAmount));

            Console.WriteLine("\nCompared CAT children quantity:");
            catList.Sort(new ICatCompare());
            catList.ForEach(cat => Console.WriteLine(cat.ChildrenAmount));

            Console.WriteLine("\nCompared BASS swimming depth:");
            bassList.Sort(new IBassComaparer());
            bassList.ForEach(bass => Console.WriteLine(bass.SwimDepth));

            Console.WriteLine("\nCompared CARP swimming depth:");
            carpList.Sort(new ICarpComparer());
            carpList.ForEach(carp => Console.WriteLine(carp.SwimDepth));

        }
    }
}