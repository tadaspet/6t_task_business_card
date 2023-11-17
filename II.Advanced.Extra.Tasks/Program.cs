using System.Text;

namespace P92_Restoranas
{
    public static class Program_Uzduotys_OOP_Supratimui
    {

        /*
         
        cia yra 3 užduotys:
        1 - [tema: interface inplementacija], concrete klasės FromFileSnakProvider sukūrimas (gebėjimas: interface panaudojimo supratimas) 
        2 - [tema: extentions metodas], sukurti metodą kuris iš stringo su asortimentu padaro sąrašą iš Snack (gebėjimas: tipo funkcionalumo išplėtimas, ka negalima prisiliesti prie tipo kodo)
        3 - [tema: property išplėtimas], 'Snak' klasės property 'Price' sukonstruoti taip, kad būtu sekamas kiekvienas kainos pakeitimas  (gebėjimas: property prasmės supratimas)
        4 - [tema: metodo naudojimas klasės properčių mutavimui], sukurkite metodus kurie:
                (1) pridėtu Alergeną, 
                (2) pašalintu Alergeną. 
                Pagalvokite ir atsakykite, kodėl įvardintus metodus neįmanoma padaryti SnakInventory klasėje (gebėjimas: metodo panaudojimo klasės viduje supratimas)
         
         */



        /// <summary>
        /// Uzduotis 1 interface inplementacija. concrete klasės sukūrimas
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var meniuProviders = new List<IAssortmentProvider>
            {
                new HardcodedSnakProvider(), //pasirinkimas 1
                new InternetSnakProvider("https://atikas.github.io/bulkdata/snacks.csv"), //pasirinkimas 2
                new FromFileSnakProvider("snacks.csv"), //pasirinkimas 3  !!!!! <<---- uzduotis 1 padaryti, kad veiktu
                new NotExistedProvider(), //bet koks kitas pasirinkimas
                                          //Q <-- potencialus klausimas - kodėl šis objektas būtinai turi būti paskutinis sąraše?
                                          //A todel kad, tai atlieka exception funkcijos analogija
            };
            var snakShop = new SnakShop(meniuProviders);
            var availableProviders = snakShop.AvailableProviders();
            Console.WriteLine(availableProviders);
            var choice = Console.ReadLine() ?? "0"; //Q <-- potencialus klausimas - kas yra dvigubas klaustukas "??" ir kokia jo čia paskirtis?
                                                    //A - jei bus neivesta i ReadLine reiksme bus nustatyta "0".
            snakShop.SetProvider(choice);
            var asortiment = snakShop.Assortment().GetAwaiter().GetResult(); //Q <-- potencialus klausimas - kodėl čia negalima rašyti await, o būtinas GetAwaiter().GetResult()?
                                                                             //A await galimas buti metode kurys yra async tipo, Main metodas yra siuo metu static.
            Console.WriteLine(asortiment);
            var snackInventory = asortiment.ToSnack().ToList();// !!!!! <<---- uzduotis 2 padaryti, kad veiktu 

            snackInventory[0].Snak.Price = 3.29m; //Q <-- potencialus klausimas - kas yra postfixas 'm' ir kokia jo paskirtis?
                                                  //A paskirtis kad skaiciaus formatavimas butu pritaikytas "money" israiskoms, t.y. neturetu double skaiciu trumpeninio apvalinimo netikslumu.
            snackInventory[0].Snak.Price = 3.99m;
            snackInventory[3].Snak.Price = 4.99m;

            var priceChanges = snackInventory
                .SelectMany(s => s.PropertyChanges)
                .Where(s => (s.Split(';').Length > 1 ? s.Split(';')[1] : "") == nameof(Snak.Price));
            Console.WriteLine(string.Join("\r\n", priceChanges)); // !!!!! <<---- uzduotis 3 padaryti, kad išvestu visus kainos pakeitimus
        }
    }



    //------------------------------------------------------------------------------------
    public class SnakShop
    {
        private readonly IEnumerable<IAssortmentProvider> _providers;

        public SnakShop(IEnumerable<IAssortmentProvider> providers) => _providers = providers;

        private IAssortmentProvider provider;

        public string AvailableProviders() => string.Join("\r\n", _providers.Select(x => x.ProviderName));
        public void SetProvider(string choice) => provider = _providers.First(x => x.ApplysTo(choice));
        public async Task<string> Assortment() 
        {
            if (provider == null) 
                throw new Exception("Please select provider"); // <-- potencialus klausimas diskusijai - ar yra prasmė šiam Exception, ką galima padaryti geriau?
            return await provider.ReadAssortment(); 
        }
    }
    
    //------------------------------------------------------------------------------------
    public interface IAssortmentProvider
    {
        bool ApplysTo(string choice); 
        //Q <-- potencialus klausimas - kodėl nėra matomumo modifikatoriaus public?
        //A Interfacai yra vienpusiskai public objektai kaip ir abstract klases.
        Task<string> ReadAssortment();
        string ProviderName { get; }
    }
    public class HardcodedSnakProvider : IAssortmentProvider
    //Q <-- potencialus klausimas - kam čia reikalingas paveldėjimas iš ISnakAssortmentProvider?
    //A todel kad yra skirtingu Tiekeju tipu ir jiems butu taikomi tokie pat interface kontrakto properciai sioms klasems:
    //HardcodedSnakProvider,
    //InternetSnakProvider,
    //FromFileSnakProvider("snacks.csv")
    //NotExistedProvider
    {
        public bool ApplysTo(string choice) => choice == "1";
        public string ProviderName => "1. Įhardkodintas asortimentas";

        public Task<string> ReadAssortment() 
            //Q <-- potencialus klausimas - kodėl nėra async modifikatoriaus?
            //A metodui nereikia laukti kitu operaciju pabaigos, jis viska turi visus duomenis ir juos gali apdoroti todel gali dirbti sinchorniskai.
        {
            return Task.FromResult(@"Type;Title;Price;Stock;Amount;Allergens;Calories
                                    Chips;Classic Potato Chips;1.99;50;200g;None;540
                                    Chips;BBQ Flavor Chips;2.49;35;200g;Nuts;560
                                    Candy;Chocolate Bar;1.50;75;100g;Milk, Soy;540
                                    Candy;Gummy Bears;1.20;65;150g;None;520
                                    Beverage;Cola Soda;0.99;150;330ml;None;150
                                    Beverage;Lemonade;1.29;120;330ml;None;140");
        }
    }
    public class InternetSnakProvider : IAssortmentProvider
    {
        private readonly string _uri;
        public InternetSnakProvider(string uri) => _uri = uri;

        public bool ApplysTo(string choice) => choice == "2";
        public string ProviderName => "2. Asortimentas iš interneto";
        public async Task<string> ReadAssortment()
        {
            try 
                //Q <-- potencialus klausimas - kodėl čia būtinas try/catch blokas?
                //A - kad butu galima valdyti problema jei puslapis butu nepasiekiamas ar informacija butu netinkama.
            {
                using (var client = new HttpClient()) 
                    //Q <-- potencialus klausimas - kodėl čia būtinas using? kokia jo paskirtis?
                    //A - todel kad systema sustabdytu prisijungima prie puslapio automatiskai (Dispose), ir taupytu kompiuterio resursus.
                {
                    var response = await client.GetAsync(_uri);
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Internet Provider error accoured: {ex.Message}");
                throw;
            }
        }
    }
    public class FromFileSnakProvider : IAssortmentProvider
    {
        public bool ApplysTo(string choice) => choice == "3";
        public string ProviderName => "3. Failo asortimentas";
        private readonly string _fName; //= "snacks.csv";
        public FromFileSnakProvider(string fileName) => _fName = fileName;

        public async Task<string> ReadAssortment()
        {
            try
            {
                StringBuilder content = new StringBuilder();
                using (var reader = new StreamReader(_fName))
                {
                    string line = "";
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        content.Append(line);
                    }
                    return content.ToString();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
    public class NotExistedProvider : IAssortmentProvider
    {
        public bool ApplysTo(string choice) => true; 
        //Q <-- potencialus klausimas - kokia šio įhardkodinto true reikšmė?
        //A nepriklausomai nuo ivesties metodas turi viena imanoma baigti.
        public Task<string> ReadAssortment() => Task.FromResult("Sorry. Choosen provider not exists");
        public string ProviderName => "";
    }

    //------------------------------------------------------------------------------------
    public static class ISnakAssortmentProviderExtentions
    {
        public static IEnumerable<SnakInventory> ToSnack(this string asortiment)
        {
            throw new NotImplementedException(); // <<---- uzduotis 2 čia leidžia padaryti pakeitimus
            //NB! atkreipti dėmesį, kad alergenai atskiriami , ir turi būti sudėti į listą. Pageidautina šiam mapinimui į listą padaryti testus.

            //return Task.FromResult(content.ToString());
            //var separate = line.Split(';');
            //if (separate.Length == 6)
            //{
            //    var separateAllerg = separate[5].Split(',');
            //    var allergList = new List<string>();
            //    foreach (var allergen in separateAllerg)
            //    {
            //        allergList.Add(allergen.Trim());
            //    }
            //    var snak = new Snak
            //    {
            //        Type = separate[0],
            //        Title = separate[1],
            //        Price = decimal.Parse(separate[2]),
            //        Stock = int.Parse(separate[3]),
            //        Allergens = allergList,
            //        Calories = int.Parse(separate[6]),
            //    };
            //}
        }
    }

    //------------------------------------------------------------------------------------
    public interface IAuditable
    {
        List<string> PropertyChanges { get; }

    }



    public class Snak : IAuditable
    {
        private List<string> propertyChanges = new();
        private string title = "";
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value) //Q <-- potencialus klausimas - kas yra 'value' kintamasis ir kokia jo paskirtis?
                                    //A value yra userio ivestis kuria norima irasyti i Title property per Setteri, tai yra specifinis Setterio Keywordas 
                {
                    propertyChanges.Add($"{DateTime.Now};{nameof(Title)};{title};{value}"); //Q <-- potencialus klausimas - kas yra nameof(Title) ir kokia jo čia paskirtis?
                                                                                            //A - nameoff paraso kintamojo - propercio pavadninima, tai naudojama matyti pasikeitimus koks kintamas is kokios i kokia reiksme pasikeite.
                    title = value;
                }
            }
        }
        public decimal Price { get; set; } // !!!!! <<---- uzduotis 3 cia leidzia padaryti keitimus
        public List<string> Allergens { get; protected set; } //Q <-- potencialus klausimas - kokia bus default Allergens reikšmė ir kodėl?
                                                              //A reiksme bus null, nes sis property niekur nera aktivuojamas arba jam priskiriama reiksme. 
        public int Calories { get; set; } //Q <-- potencialus klausimas - kokia bus default Calories reikšmė ir kodėl?
                                          //A int tipo kintamuju reiksme standartiskai bus 0, jei nebus incializuota.

        public List<string> PropertyChanges { get => propertyChanges; protected set => propertyChanges = value; }

        //!!!!! <<---- uzduotis 4 cia leidzia padaryti keitimus

    }

    //------------------------------------------------------------------------------------
    public class SnakInventory : IAuditable
    {
        private List<string> propertyChanges = new();

        public Snak Snak { get; init; } //Q <-- potencialus klausimas - pagal esamą funkcionalumą SnakInventory klasę galima sukonstruoti nepriskytus properčio Snack, kas veda prie potentialaus bug'o. Kaip būtu galima ištaisyti šią situaciją?
                                        //A Snak klases getteriui reiketu patikrinimo ar Title propery nera null ar tuscias arba naudojant Snack konstruktoriu kuriame reiketu ivesti butina informacija.
        public string Amount { get; protected set; } //Q <-- potencialus klausimas - kodėl Amount properčio tipas yra string?
                                                     //A nes nuskaitomi duomenys is failo yra string tipo ir nera konvertuoti i skaitines israiskas.       
        public void ChangeAmount(string newAmount) 
        {
            if (Amount != newAmount)//Q <-- potencialus klausimas diskusijai - kodėl validatoriams pvz "newAmount >= 0" čia ne vieta, o gal vieta?
                                    //A Amount yra string tipo, todel nebutu galima lyginti su skaitine israiska.
            {
                propertyChanges.Add($"{DateTime.Now};{nameof(Amount)};{Amount};{newAmount}");
                Amount = newAmount;
            }
        }
        public List<string> PropertyChanges { get => propertyChanges; private set => propertyChanges = value; }
    }
}
