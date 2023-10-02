namespace _3.InheritanceAndVirtualMetods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Material
            //Square square = new Square(3);
            //Console.WriteLine($"Kvadratas turi {square.NumberOfAngles} kampus");
            //Console.WriteLine($"Kvadrato krastines ilgis: {square.Size}");

            //Console.WriteLine($"Kvadrato perimetras: {square.GetPerimeter()}");


            //Console.WriteLine("---------//---------");

            //Entity entity = new Entity();
            //Human human = new Human();
            //Employee employee = new Employee();
            //entity.Id = 1; // Entity turi tik ID nes yra tevine klase ir pati is nieko nepaveldi

            //// human tures savo properties ir Entity klases
            //human.Name = "Tadas";
            //human.Surname = "Petruitis";
            //human.Birthday = ;
            //human.Id = entity.Id;

            //employee.Salary = 1000;
            //employee.EmploymentDate = DateTime.Now;
            //employee.Name = human.Name;
            //employee.Surname = human.Surname;
            //employee.Birthday = human.Birthday;
            //employee.Id = human.Id;

            //Console.WriteLine($"Atlyginimas - {employee.Salary}" +
            //    $"\nIsidarbinimas - {employee.EmploymentDate}" +
            //    $"\nVardas - {employee.Name}" +
            //    $"\nPavarde - {employee.Surname}" +
            //    $"\nGimtadienis - {employee.Birthday}" +
            //    $"\nAsmens kodas - {employee.Id}");


            #endregion

            #region Task 11
            //Console.WriteLine("------------------");
            //Car newCar = new Car(200);
            //Console.WriteLine($"Car speed: {newCar.Speed}");
            //Console.WriteLine("------------------");
            //Console.WriteLine("------------------");
            //Bike newBike = new Bike(35);
            //Console.WriteLine($"Bike speed: {newBike.Speed}");
            //Console.WriteLine("------------------");
            #endregion

            #region Task 12
            //Console.WriteLine("------------------");
            //_122manager newManeger = new _122manager();
            //newManeger.Name = "Aurimas Karaliunas";
            //newManeger.Salary = 10000;
            //Console.WriteLine($"Vadovo vardas: {newManeger.Name}\n" +
            //    $"Vadovo atlyginimas: {newManeger.Salary}\n" +
            //    $"Darbuotoju skaicius: {newManeger.Employees}");
            //Console.WriteLine("------------------");
            #endregion

            #region Task 13
            //Console.WriteLine("------------------");
            //Programmer newProg = new Programmer();
            //newProg.Name = "Pitonas Duomenis";
            //newProg.Salary = 2000;
            //Programmer newProg2 = new Programmer();
            //newProg2.Name = "Kestas Kabliukas";
            //newProg2.Salary = 2100;
            //Programmer newProg3 = new Programmer();
            //newProg3.Name = "Skliaustelis Grotazimys";
            //newProg3.Salary = 3000;
            //List<Programmer> gang = new List<Programmer>
            //{ newProg, newProg2, newProg3 };
            //Manager(gang);
            //Console.WriteLine($"Programuotojo vardas: {newProg.Name}\n" +
            //    $"Programuotojo atlyginimas: {newProg.Salary}\n" +
            //    $"Programuotojo kalba: {newProg.ProgrammingLanguage}");
            //Console.WriteLine("------------------");
            #endregion

            #region Task 21
            //Console.WriteLine("------------------");
            //Food item = new Food();
            //item.Name = "Konservai";
            //item.Price = 10;
            //item.ExpirationTime = DateTime.Now.AddDays(14);
            //Console.WriteLine($"Maisto produktas: {item.Name}\n" +
            //    $"Kaina: {item.Price}\n" +
            //    $"Galiojimo laikas: {item.ExpirationTime}");
            //Console.WriteLine("------------------");
            //Food item2 = new Food();
            //item2.Name = "Televizorius";
            //item2.Price = 499;
            //item2.ExpirationTime = DateTime.Now.AddYears(2);
            //Console.WriteLine($"Eltronikos preke: {item2.Name}\n" +
            //    $"Kaina: {item2.Price}\n" +
            //    $"Garantijos pabaiga: {item2.ExpirationTime}");
            //Console.WriteLine("------------------");
            #endregion

            #region
            //Console.WriteLine("------------------");
            //Transport newSpeed = new Transport();
            //Console.WriteLine($"Pamatuotas greitis: {newSpeed.MeasureSpee()}");
            //Console.WriteLine("Override pamatuotas greitis:");
            //Car2 car2 = new Car2();
            //car2.Speed = 12;
            //Console.WriteLine($"Pamatuotas greitis: {car2.MeasureSpee()}");
            //Console.WriteLine("------------------");
            #endregion

            #region
            //Console.WriteLine("------------------");
            //Employee322 newEmp = new Employee322();
            //Console.WriteLine($"Pasveikinimas!\n" +
            //    $"{newEmp.Greeting()}");
            //Console.WriteLine("------------------");
            //Manager322 newManager = new Manager322();
            //newManager.NameManger = "Vladas AUgustinas";
            //Console.WriteLine($"Imones pasveikinimas!\n" +
            //    $"{newManager.Greeting()}");
            //Console.WriteLine("------------------");
            #endregion


            #region
            Console.WriteLine("------------------");
            Shape411 newShape = new Shape411();
            Console.WriteLine($"{newShape.Draw()}");
            Rectangle411 newRectangle = new Rectangle411();
            Circle411 newCircle = new Circle411();
            Console.WriteLine("Override ir virtualus metodas 1:");
            Console.WriteLine($"Figura 1: {newRectangle.Draw()}");
            Console.WriteLine("Override ir virtualus metodas 1:");
            Console.WriteLine($"Figura 2: {newCircle.Draw()}");
            Console.WriteLine("------------------");
            #endregion


        }
        static void Manager(List<Programmer> gang)
        {
            foreach (var emp in gang)
            {
                Console.WriteLine($"Programuotojo vardas: {emp.Name}\n" +
                    $"Programuotojo atlyginimas: {emp.Salary}\n" +
                    $"Programuotojo kalba: {emp.ProgrammingLanguage}");
                Console.WriteLine("------------------");
            }
        }
    }
}