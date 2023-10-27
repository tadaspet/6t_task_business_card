namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person
            {
                Name = "Jonas",
                Pets = new List<Pets>
                {
                    new Pets { PetName = "Antis", PetAge = 12 },
                    new Pets { PetName = "Balandis", PetAge = 3 },
                    new Pets { PetName = "Sakalas", PetAge = 7 },
                },
            };
            var person2 = new Person
            {
                Name = "Saulius",
                Pets = new List<Pets>
                {
                    new Pets { PetName = "Karve", PetAge = 5 },
                    new Pets { PetName = "Arklys", PetAge = 4 },
                    new Pets { PetName = "Asilas", PetAge = 7 },
                },
            };
            var person3 = new Person
            {
                Name = "Martynas",
                Pets = new List<Pets>
                {
                    new Pets { PetName = "Suo", PetAge = 7 },
                    new Pets { PetName = "Kate", PetAge = 3 },
                    new Pets { PetName = "Ziurkenas", PetAge = 1 },
                },
            };

            List<Person> peopleList = new List<Person> { person1, person2, person3};

            Console.WriteLine("--------------\nAll Peopole Pet List:");
            List<Pets> petList = peopleList.SelectMany(p => p.Pets).ToList();
            //List<string> petNames = petList.Select(p => p.PetName).ToList();

            petList.ForEach(p => Console.WriteLine($"Pet: {p.PetName}\tAge:{p.PetAge}"));

            Console.WriteLine("\nPet list with names from A:");
            List<Pets> petListFomA = petList.Where(name => name.PetName[0]=='A').ToList();
            petListFomA.ForEach(p => Console.WriteLine($"Pet: {p.PetName}"));

            Console.WriteLine("\nPet list with names from A and older than 5:");
            List<Pets> petsNameAAge5 = petList.Where(name => name.PetName[0]=='A' && name.PetAge > 5).ToList();
            petsNameAAge5.ForEach(p => Console.WriteLine($"Pet: {p.PetName}\tAge: {p.PetAge}"));


        }
    }
}