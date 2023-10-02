namespace _18.Object_Orentiad_Programing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Enter Name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Surname:");
            //string lastName = Console.ReadLine();


            //Persons persons = new Persons(name, lastName);

            //do
            //{
            //    Console.WriteLine("Green Grass with tail but not a mouse. What?");
            //    string input = Console.ReadLine();

            //    if ( input == "1")
            //    {
            //        persons.Points++;
            //    }

            //} while (true);

            //Console.WriteLine(persons.Name);
            //Console.WriteLine(persons.LastName);
            //Console.WriteLine(persons.Age);
            //Console.WriteLine(persons.CreatedOn);

            //Car myCar = new Car();
            //myCar.Brand = "Honda";
            //myCar.Doors = 5;
            //myCar.MaxSpeed = 220;
            //myCar.CreationDate = new DateTime(2009, 10, 06);

            //Console.WriteLine($"Automobilio gamintojas: {myCar.Brand}");
            //Console.WriteLine($"Duru skaicius: {myCar.Doors}");
            //Console.WriteLine($"Maksimalus greitis: {myCar.MaxSpeed}");
            //Console.WriteLine($"Pagaminimo Data: {myCar.CreationDate}");

            //Console.WriteLine("--------------------------------------");
            //Car emptyCar = new Car();
            //Console.WriteLine($"Automobilio gamintojas: {emptyCar.Brand}");
            //Console.WriteLine($"Duru skaicius: {emptyCar.Doors}");
            //Console.WriteLine($"Maksimalus greitis: {emptyCar.MaxSpeed}");
            //Console.WriteLine($"Pagaminimo Data: {emptyCar.CreationDate}");

            Car carWithBrand = new Car("BMW")
            {
                Doors = 5,
                Engine = new Engine()
                {
                    Name = "V8",
                    Description = "V8 Engine",
                    ReleaseDate = DateTime.Now,
                    EngineRun = true,
                },
                Wheels = new List<Wheel>()
                {
                    new Wheel() {Brand = "Continental", Size = "R15", },
                    new Wheel() {Brand = "Continental", Size = "R15", },
                    new Wheel() {Brand = "Continental", Size = "R15", },
                    new Wheel() {Brand = "Continental", Size = "R15", },
                }
            };

            Console.WriteLine($"Automobilio gamintojas: {carWithBrand.Brand}");
            Console.WriteLine($"Duru skaicius: {carWithBrand.Doors}");
            Console.WriteLine($"Pagaminimo Data: {carWithBrand.CreationDate}");
            Console.WriteLine($"Variklio pavadinimas: {carWithBrand.Engine.Name}");
            Console.WriteLine($"Variklio aprasymas: {carWithBrand.Engine.Description}");
            Console.WriteLine($"Variklio isleidimo data: {carWithBrand.Engine.ReleaseDate}");
            foreach(var wheel in carWithBrand.Wheels)
            {
                Console.WriteLine($"Ratas {wheel.Brand} ir jo dydis {wheel.Size}");
            }
            RunningEngine(carWithBrand);

            #endregion

            #region Task 11
            //Console.WriteLine("----------------------");
            //Person human = new Person("Zmogus", 30);
            //Console.WriteLine($"OOP Naujos klases zmogus.\nVardas: {human.Name}\nAmzius: {human.Age}");
            //Console.WriteLine("----------------------");
            #endregion

            #region Task 12
            //Console.WriteLine("----------------------");
            //Person human2 = new Person("Vardesnis",22);
            //human2.Height = 1.70;
            //Console.WriteLine($"OOP Naujos klases zmogus.\nVardas: {human2.Name}\nAmzius: {human2.Age}\nAukstis: {human2.Height}");
            //Console.WriteLine("----------------------");
            #endregion

            #region Task 13
            //Console.WriteLine("----------------------");
            //School primarySiauliai = new School("Pagrandukai","Siauliai");
            //Console.WriteLine($"OOP Klase School;\nPavadinimas: {primarySiauliai.Name}\nMiestas: {primarySiauliai.City}");
            //Console.WriteLine("----------------------");
            #endregion

            #region Task 14
            //Console.WriteLine("----------------------");
            //School primSchool = new School("Pagrandukai","Siauliai", 20);
            //Console.WriteLine($"OOP Klase School;\nPavadinimas: {primSchool.Name}\nMiestas: {primSchool.City}" +
            //    $"\nMokiniu sk.: {primSchool.Pupils}");
            //Console.WriteLine("----------------------");
            #endregion

            #region Task 21
            //Console.WriteLine("----------------------");
            //Book book = new Book("Lengvas budas mesti rukyti", "Allen Carr", 2007);
            //Console.WriteLine("////KNYGU KLASE////");
            //Console.WriteLine($"Pavadinimas: {book.Title}");
            //Console.WriteLine($"Autorius: {book.Author}");
            //Console.WriteLine($"Metai: {book.Year}");
            //Console.WriteLine("----------------------");
            #endregion

            #region Task 22
            //Console.WriteLine("----------------------");
            //Book book2 = new Book("Lengvas budas mesti rukyti", "Allen Carr", 2007);
            //book2.OriginCountry = "Lietuva";
            //Console.WriteLine("////KNYGU KLASE////");
            //Console.WriteLine($"Pavadinimas: {book2.Title}");
            //Console.WriteLine($"Autorius: {book2.Author}");
            //Console.WriteLine($"Metai: {book2.Year}");
            //Console.WriteLine($"Salis: {book2.OriginCountry}");
            //Console.WriteLine("----------------------");
            #endregion

            #region 23
            //Console.WriteLine("----------------------");
            //List<string>  bookList = new List<string>
            //{"Biblija", "Enciklopedija", "Vadovelis" };
            //List<string> authorList = new List<string>
            //{ "Kunigas", "Mokslinikas", "Mokslininkas"};
            //Book book3 = new Book("");


            //Console.WriteLine("----------------------");
            #endregion

            #region Task 4.2
            //Console.WriteLine("----------------------");
            //Person personAddress = new Person()
            //{
            //    Name = "Tadas",
            //    Age = 36,
            //    Address = new Address()
            //    {
            //        City = "Siauliai",
            //        Street = "Architektu",
            //    }
            //};
            //Console.WriteLine($"Vardas: {personAddress.Name}" +
            //    $"\nAmzius: {personAddress.Age}" +
            //    $"\nMiestas: {personAddress.Address.City}" +
            //    $"\nGatve: {personAddress.Address.Street}");

            //Console.WriteLine("----------------------");
            #endregion


            #region Task 4.3
            Console.WriteLine("----------------------");
            BankAccount();
            Console.WriteLine("----------------------");
            #endregion
        }

        public static void RunningEngine(Car car)
        {
            if ( car.Engine.EngineRun == true) 
            {
                Console.WriteLine("Engine On");
            }
            else
            {
                Console.WriteLine("Engine Off");
            }
        }

        public static void BankAccount()
        {

            //Console.WriteLine($"Iveskite savo Varda ir Pavarde saskaitos atidarymui:");
            //string account = Console.ReadLine();
            //Console.WriteLine("Iveskite inesamos sumos");
            //double balance = Convert.ToDouble( Console.ReadLine() );
            //Bank newBank = new Bank("");
            //{
            //    //Account1 = new Account()
            //    //{
            //    //    Owner = account,
            //    //    Ballance = balance,
            //    //};

            //}

            //Console.WriteLine($"Jusu bankas: {newBank.BankName}");
            //Console.WriteLine($"Saskaitos valdytojas: {newBank.Account.Owner}");
            //Console.WriteLine($"Saskaitos balanas: {newBank.Account.Ballance}");

        }
    }
}


//Inheritance
//abstraction
//polymoprhism
//encapsulation