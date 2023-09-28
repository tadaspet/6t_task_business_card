public static class SwitchCases
{
    public static void Main(string[] args)
    {

    }
    ////Console.WriteLine("Iveskite savo ivertinimo dydi (0-100), kad suzinoti pazimy:");
    ////string inPut = Console.ReadLine();
    ////int score = Convert.ToInt32(inPut);
    ////string grade = score switch
    ////{
    ////    < 50 => "F",
    ////    < 60 => "E",
    ////    < 70 => "D",
    ////    < 80 => "C",
    ////    < 90 => "B",
    ////    _ => "A",
    ////};
    ////Console.WriteLine($"Jusu ivertinimas - {grade}.");

    public static string DayAnswer(string dayNum)
    {
        int day = Convert.ToInt32(dayNum);
        switch (day)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
                break;
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid week no.";
        }
    }

    //Console.WriteLine("------------1.2-----------------");
    //Console.WriteLine("Iveskite savo amziu:");
    //string inPut2 = Console.ReadLine();
    //int age = Convert.ToInt32(inPut2);
    //string print = age switch
    //{
    //    <= 0 => "Amzius neegzistuoja",
    //    < 7 => "Vaikas",
    //    < 19 => "Moksleivis",
    //    < 26 => "Studentas",
    //    < 66 => "Darbuotojas",
    //    _ => "Pensininkas",
    //};
    //Console.WriteLine($"{print}.");
    //Console.WriteLine("================================");

    //Console.WriteLine("------------1.3-----------------");
    //Console.WriteLine("Iveskite metus ir menesi (2000-1):");
    //string inPut3 = Console.ReadLine();
    //string month2 = inPut3.Substring(5);
    //int month = Convert.ToInt32(month2);
    //switch (month)
    //{
    //    case 1:
    //        Console.WriteLine("Sausis");
    //        break;
    //    case 2:
    //        Console.WriteLine("Vasaris");
    //        break;
    //    case 3:
    //        Console.WriteLine("Kovas");
    //        break;
    //    case 4:
    //        Console.WriteLine("Balandis");
    //        break;
    //    case 5:
    //        Console.WriteLine("Geguze");
    //        break;
    //    case 6:
    //        Console.WriteLine("Birzelis");
    //        break;
    //    case 7:
    //        Console.WriteLine("Liepa");
    //        break;
    //    case 8:
    //        Console.WriteLine("Rugpjutis");
    //        break;
    //    case 9:
    //        Console.WriteLine("Rugsejis");
    //        break;
    //    case 10:
    //        Console.WriteLine("Spalis");
    //        break;
    //    case 11:
    //        Console.WriteLine("Lapkritis");
    //        break;
    //    case 12:
    //        Console.WriteLine("Gruodis");
    //        break;
    //    default:
    //        Console.WriteLine("Netinkamai ivesta data. Kartokite");
    //        break;
    //};
    //Console.WriteLine("================================");

    public static string MonthAnswer(string MonthNo)
    {
        //Console.WriteLine("------------1.3-----------------");
        //Console.WriteLine("Iveskite metus ir menesi (2000-1):");
        string MonthName = MonthNo.Substring(5) switch
        {
            "1" => "Sausis",
            "2" => "Vasaris",
            "3" => "Kovas",
            "4" => "Balandis",
            "5" => "Geguze",
            "6" => "Birzelis",
            "7" => "Liepa",
            "8" => "Rugpjutis",
            "9" => "Rugsejis",
            "10" => "Spalis",
            "11" => "Lapkritis",
            "12" => "Gruodis",
            _ => "Nera tokio menesio"
        };
        return MonthName;
    }
    //Console.WriteLine("Datoje ivestas menuo - " + month2);
    //Console.WriteLine("================================");

    //Console.WriteLine("------------2.1-----------------");
    //Console.WriteLine("Iveskite figuros pavadinima:\n(Kvadratas, Apskritimas, Trikampis, Staciakampis)");
    //string inPut21 = Console.ReadLine();
    //string figureLow = inPut21.ToLower();
    //switch (figureLow)
    //{
    //    case "kvadratas":
    //        Console.WriteLine("Iveskite Kvadrato krastines ilgi:");
    //        string kvadInPut = Console.ReadLine();
    //        int kvadLine = Convert.ToInt32(kvadInPut);
    //        double kvadArea = kvadLine * kvadLine;
    //        Console.WriteLine($"Kvadrato plotas {Math.Round(kvadArea, 2)}.");
    //        break;
    //    case "apskritimas":
    //        Console.WriteLine("Iveskite Apskritimo spindulio ilgi:");
    //        string circInPut = Console.ReadLine();
    //        int circRadius = Convert.ToInt32(circInPut);
    //        double circArea = Math.PI * circRadius * circRadius;
    //        Console.WriteLine($"Apskritimo plotas {Math.Round(circArea, 2)}.");
    //        break;
    //    case "trikampis":
    //        Console.WriteLine("Iveskite Trikampo aukstine ilgi:");
    //        string triangleInput1 = Console.ReadLine();
    //        Console.WriteLine("Iveskite Trikampo pagrindo ilgi:");
    //        string triangleInput2 = Console.ReadLine();
    //        int triagleHeight = Convert.ToInt32(triangleInput1);
    //        int triagleBase = Convert.ToInt32(triangleInput2);
    //        double triangleArea = .5 * triagleHeight * triagleBase;
    //        Console.WriteLine($"Trikampio plotas {Math.Round(triangleArea, 2)}.");
    //        break;
    //    case "staciakampis":
    //        Console.WriteLine("Iveskite Staciakampio ploti:");
    //        string rectWidth = Console.ReadLine();
    //        Console.WriteLine("Iveskite Staciakampio auksti:");
    //        string rectHeight = Console.ReadLine();
    //        int rectWidthCalc = Convert.ToInt32(rectWidth);
    //        int rectHeightCalc = Convert.ToInt32(rectHeight);
    //        double rectArea = rectWidthCalc * rectHeightCalc;
    //        Console.WriteLine($"Trikampio plotas {Math.Round(rectArea, 0)}.");
    //        break;
    //    default:
    //        Console.WriteLine("Figura neatitinka leidziamo pasirinkimo");
    //        break;
    //}
    //Console.WriteLine("================================");

    //Console.WriteLine("------------2.2-----------------");
    //Console.WriteLine("Pasirinkite viena pagrindini elementa:\n(Ugnis, Vanduo, Oras, Zeme, Eteris)");
    //string inPut22 = Console.ReadLine();
    //string elementLow22 = inPut22.ToLower();
    //switch (elementLow)
    //{
    //    case "ugnis":
    //        Console.WriteLine("Pasirinkitas elementas Ugnis:\nJi simbolizuoja - Energija ir Transformacija!");
    //        break;
    //    case "vanduo":
    //        Console.WriteLine("Pasirinkitas elementas Vanduo:\nJis simbolizuoja - Sklanduma ir Prisitaikyma!");
    //        break;
    //    case "oras":
    //        Console.WriteLine("Pasirinkitas elementas Oras:\nJis simbolizuoja - Judejima ir Kaita!");
    //        break;
    //    case "zeme":
    //        Console.WriteLine("Pasirinkitas elementas Zeme:\nJi simbolizuoja - Tvirtima ir Stabiluma!");
    //        break;
    //    case "eteris":
    //        Console.WriteLine("Pasirinkitas elementas Eteris:\nJis simbolizuoja - Erdve, kurioje egzistuoja Ugnis, Vanduo, Oras, Zeme!");
    //        break;
    //        default: 
    //        Console.WriteLine("Tokio elemento nera arba ivesta neteisingai.\nBandykite dar karta! ");
    //        break;
    //}

    //Console.WriteLine("------------2.3-----------------");
    //Console.WriteLine("Pasirinkite studiju krypti ir suzinosite ar galite studijuoti!\n(Matematika, Informatika, Biologija, Chemija)");
    //string inPut23 = Console.ReadLine();
    //string elementLow23 = inPut23.ToLower();
    //Console.WriteLine($"Pasirinkitas studiju kryptis: {inPut23}\nIveskite savo mokyklos vidurki (0-10):");
    //string ave1 = Console.ReadLine();
    //double ave11 = Convert.ToDouble(ave1);
    //Console.WriteLine("Koks Jusu egzamino rezultatas (0 - 10):");
    //string egz1 = Console.ReadLine();
    //double egz11 = Convert.ToDouble(egz1);
    //Console.WriteLine("Koks Jusu bendras visu egzaminu vidurkis:");
    //string egzAve1 = Console.ReadLine();
    //double egzAve11 = Convert.ToDouble(egzAve1);

    //switch (elementLow23)
    //{
    //    case "matematika":
    //        Console.WriteLine("Matematikos vidurkio svertas - 2, egzamino - 5, o bendras vidurkis - 3.");
    //        double rez1 = (ave11 * 2 + egz11 * 5 + egzAve11 * 3) / 10;
    //        Console.WriteLine("Jusu rezultai:\nVidurkis - " + (ave11 * 2) + "\nEgazaminas - " + (egz11 * 5) + "\nBendras vidurkis - " + (egzAve11 * 3));
    //        Console.WriteLine($"Bendra suma {rez1 * 10} ir Jusu stojimo balas - {Math.Round(rez1, 1)}");
    //        switch (rez1)
    //        {
    //            case < 8:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJums reikia pagerinti zinias Matematikos srityje.\nJusu stojimo balas yra mazesnis uz 8 balu riba.");
    //                break;
    //            case <= 10:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJus galite sekmingai studijuoti Matematika, nes Jusu stojimo balas yra aukstenis uz 8 balu riba.");
    //                break;
    //            default:
    //                Console.WriteLine($"Toks balas nesuskaiciuojamas: {Math.Round(rez1, 1)}.");
    //                break;
    //        };
    //        break;
    //    case "informatika":
    //        Console.WriteLine("Informatikos vidurkio svertas - 3, egzamino - 4, o bendras vidurkis - 3.");
    //        double rez2 = (ave11 * 3 + egz11 * 4 + egzAve11 * 3) / 10;
    //        Console.WriteLine("Jusu rezultai:\nVidurkis - " + (ave11 * 3) + "\nEgazaminas - " + (egz11 * 4) + "\nBendras vidurkis - " + (egzAve11 * 3));
    //        Console.WriteLine($"Bendra suma {rez2 * 10} ir Jusu stojimo balas - {Math.Round(rez2, 1)}");
    //        switch (rez2)
    //        {
    //            case < 8:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJums reikia pagerinti zinias Informatikos srityje.\nJusu stojimo balas yra mazesnis uz 8 balu riba.");
    //                break;
    //            case <= 10:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJus galite sekmingai studijuoti Informatika, nes Jusu stojimo balas yra aukstenis uz 8 balu riba.");
    //                break;
    //            default:
    //                Console.WriteLine($"Toks balas nesuskaiciuojamas: {Math.Round(rez2, 1)}.");
    //                break;
    //        };
    //        break;
    //    case "biologija":
    //        Console.WriteLine("Biologijos vidurkio svertas - 4, egzamino - 4, o bendras vidurkis - 2.");
    //        double rez3 = (ave11 * 4 + egz11 * 4 + egzAve11 * 3) / 10;
    //        Console.WriteLine("Jusu rezultai:\nVidurkis - " + (ave11 * 4) + "\nEgazaminas - " + (egz11 * 4) + "\nBendras vidurkis - " + (egzAve11 * 2));
    //        Console.WriteLine($"Bendra suma {rez3 * 10} ir Jusu stojimo balas - {Math.Round(rez3, 1)}");
    //        switch (rez3)
    //        {
    //            case < 8:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJums reikia pagerinti zinias Biologijos srityje.\nJusu stojimo balas yra mazesnis uz 8 balu riba.");
    //                break;
    //            case <= 10:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJus galite sekmingai studijuoti Biologija, nes Jusu stojimo balas yra aukstenis uz 8 balu riba.");
    //                break;
    //            default:
    //                Console.WriteLine($"Toks balas nesuskaiciuojamas: {Math.Round(rez3, 1)}.");
    //                break;
    //        };
    //        break;
    //    case "chemija":
    //        Console.WriteLine("Chemijos vidurkio svertas - 3, egzamino - 5, o bendras vidurkis - 2.");
    //        double rez4 = (ave11 * 3 + egz11 * 5 + egzAve11 * 2) / 10;
    //        Console.WriteLine("Jusu rezultai:\nVidurkis - " + (ave11 * 3) + "\nEgazaminas - " + (egz11 * 5) + "\nBendras vidurkis - " + (egzAve11 * 2));
    //        Console.WriteLine($"Bendra suma {rez4 * 10} ir Jusu stojimo balas - {Math.Round(rez4, 1)}");
    //        switch (rez4)
    //        {
    //            case < 8:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJums reikia pagerinti zinias Chemijos srityje.\nJusu stojimo balas yra mazesnis uz 8 balu riba.");
    //                break;
    //            case <= 10:
    //                Console.WriteLine($"Stojimo galimybiu atsakymas:\nJus galite sekmingai studijuoti Chemijos, nes Jusu stojimo balas yra aukstenis uz 8 balu riba.");
    //                break;
    //            default:
    //                Console.WriteLine($"Toks balas nesuskaiciuojamas: {Math.Round(rez4, 1)}.");
    //                break;
    //        };
    //        break;
    //    default:
    //        Console.WriteLine("Tokios studijos krypties nera.\nBandykite dar karta! ");
    //        break;
    //};

    //Console.WriteLine("------------3.1-----------------");
    //Console.WriteLine("Iveskite Menesio skaiciu ir suzinosite koks tai yra metu laikas:");
    //string inPut31 = Console.ReadLine();
    //int count31 = Convert.ToInt32(inPut31);
    //string month31 = count31 switch
    //{
    //    <= 0 => "Neegzistuoja",
    //    < 3 => "Ziema",
    //    < 6 => "Pavasris",
    //    < 9 => "Vasara",
    //    < 12 => "Ruduo",
    //    < 13 => "Ziema",
    //    _ => "Neegzistuoja",
    //};
    //Console.WriteLine("Jusu megstamas laikas " + month31);

    //Console.WriteLine("------------3.2-----------------");
    //Console.WriteLine("Pasirinkite aritmetini veiksma:\n(Sudetis, Atimtis, Daugyba, Dalyba, Kelimas Laipsniu, Saknies Traukimas)");
    //string inPut32 = Console.ReadLine();
    //string artimet32 = inPut32.ToLower();
    //switch (artimet32)
    //{
    //    case "sudetis":
    //        Console.WriteLine("Iveskite du skaicius:");
    //        string sumInPut31 = Console.ReadLine();
    //        string sumInPut32 = Console.ReadLine();
    //        int sumValue31 = Convert.ToInt32(sumInPut31);
    //        int sumValue32 = Convert.ToInt32(sumInPut32);
    //        int sumSum = sumValue31 + sumValue32;
    //        Console.WriteLine($"Skaiciu {sumValue31} ir {sumValue32} sumos rezultatas = {sumSum}.");
    //        break;
    //    case "atimtis":
    //        Console.WriteLine("Iveskite du skaicius, is pirmo skaiciaus bus atimtas antrasis:");
    //        string sumInPut321 = Console.ReadLine();
    //        string sumInPut322 = Console.ReadLine();
    //        int subValue321 = Convert.ToInt32(sumInPut321);
    //        int subValue322 = Convert.ToInt32(sumInPut322);
    //        int subSum = subValue321 - subValue322;
    //        Console.WriteLine($"Skaiciu {subValue321} ir {subValue322} atimties rezultatas = {subSum}.");
    //        break;
    //    case "daugyba":
    //        Console.WriteLine("Iveskite du skaicius:");
    //        string multInPut331 = Console.ReadLine();
    //        string multInPut332 = Console.ReadLine();
    //        int multValue331 = Convert.ToInt32(multInPut331);
    //        int multValue332 = Convert.ToInt32(multInPut332);
    //        int multSum = multValue331 * multValue332;
    //        Console.WriteLine($"Skaiciaus {multValue331} ir {multValue332} daugybos rezultatas = {multSum}.");
    //        break;
    //    case "dalyba":
    //        Console.WriteLine("Iveskite du skaicius, pirmas skaicius bus vardiklis antrasis daliklis:");
    //        string divInPut341 = Console.ReadLine();
    //        string divInPut342 = Console.ReadLine();
    //        double divValue341 = Convert.ToDouble(divInPut341);
    //        double divValue342 = Convert.ToDouble(divInPut342);
    //        double divSum = divValue341 / divValue342;
    //        Console.WriteLine($"Skaiciaus {divValue341} ir {divValue342} dalybos rezultatas = {Math.Round(divSum,2)}.");
    //        break;
    //    case "kelimas laipsniu":
    //        Console.WriteLine("Iveskite du skaicius, pirmas skaicius bus pakeltas antrojo skaiciaus laipsniu:");
    //        string invInPut351 = Console.ReadLine();
    //        string invlInPut352 = Console.ReadLine();
    //        int invlValue351 = Convert.ToInt32(invInPut351);
    //        int invlValue342 = Convert.ToInt32(invlInPut352);
    //        double invlSum = Math.Pow(invlValue351, invlValue342);
    //        Console.WriteLine($"Skaiciaus {invlValue351} pakeltas {invlValue342} laipsniu rezultatas = {invlSum}.");
    //        break;
    //    case "saknies traukimas":
    //        Console.WriteLine("Iveskite du skaicius, pirmas skaicius bus saknyje, o antrasis bus saknies laipsnis:");
    //        string rootInPut361 = Console.ReadLine();
    //        string rootlInPut362 = Console.ReadLine();
    //        int rootlValue361 = Convert.ToInt32(rootInPut361);
    //        int rootlValue362 = Convert.ToInt32(rootlInPut362);
    //        double rootSum = Math.Pow(rootlValue361, 1.0 / rootlValue362);
    //        Console.WriteLine($"Skaiciaus {rootlValue361} saknis traukiam {rootlValue362} laipsniu duoda rezultata = {rootSum}.");
    //        break;
    //    default:
    //        Console.WriteLine("Aritmetinis veiksmas arba skaiciai netinkami.\nBandykite dar karta");
    //        break;
    //}
    //Console.WriteLine("================================");


    //Console.WriteLine("------------3.3-----------------");
    //Console.WriteLine("Valiutos konvertavimas. Iveskite suma ir valiutos rusi.\n(Valiutos rusys: USD, EUR, GBP, JPY)");
    //public static double ConvertCurrency(string number, string currency)
    //        {
    //            string inPut331 = "100";
    //            string inPut332 = "USD";
    //            double amount33 = Convert.ToDouble(inPut331);
    //            string cur33 = inPut332.ToUpper();
    //            double eurUSD = 1.0886;
    //            double eurEUR = 1.0000;
    //            double eurGBP = 0.8592;
    //            double eurJPY = 159.15;
    //            //Console.WriteLine("Valiutu kursai:");
    //            //Console.WriteLine($"EUR = {eurEUR};\nUSD = {eurUSD};\nGBP = {eurGBP};\nJPY = {eurJPY}.");
    //            switch (cur33)
    //            {
    //                case "USD":
    //                    ///Console.WriteLine($"Konvertuota pinigu suma: {amount33} {cur33} butu lygi:");
    //                    double USDtoEUR = amount33 / eurUSD;
    //                    //double USDtoGBP = amount33 * (eurGBP / eurUSD);
    //                    //double USDtoJPY = amount33 * (eurJPY / eurUSD);
    //                    return (USDtoEUR);
    //                //Console.WriteLine($"1.{Math.Round(USDtoEUR, 2)} EUR;\n2.{Math.Round(USDtoGBP, 2)} GBP;\n3.{Math.Round(USDtoJPY, 2)} JPY.");
    //                //break;
    //                case "EUR":
    //                    //Console.WriteLine($"Konvertuota pinigu suma: {amount33} {cur33} butu lygi:");
    //                    double EURtoUSD = amount33 * eurUSD;
    //                    //double EURtoGBP = amount33 * (eurGBP / eurEUR);
    //                    //double EURtoJPY = amount33 * (eurJPY / eurEUR);
    //                    //Console.WriteLine($"1.{Math.Round(EURtoUSD, 2)} USD;\n2.{Math.Round(EURtoGBP, 2)} GBP;\n3.{Math.Round(EURtoJPY, 2)} JPY.");
    //                    return (EURtoUSD);
    //                //break;
    //                case "GBP":
    //                    //Console.WriteLine($"Konvertuota pinigu suma: {amount33} {cur33} butu lygi:");
    //                    double GBPtoEUR = amount33 * (eurEUR / eurGBP);
    //                    //double GBPtoUSD = amount33 * (eurUSD / eurGBP);
    //                    //double GBPtoJPY = amount33 * (eurJPY / eurGBP);
    //                    //Console.WriteLine($"1.{Math.Round(GBPtoEUR, 2)} EUR;\n2.{Math.Round(GBPtoUSD, 2)} USD;\n3.{Math.Round(GBPtoJPY, 2)} JPY.");
    //                    return (GBPtoEUR);
    //                //break;
    //                case "JPY":
    //                    //Console.WriteLine($"Konvertuota pinigu suma: {amount33} {cur33} butu lygi:");
    //                    double JPYtoUSD = amount33 * (eurUSD / eurJPY);
    //                    //double JPYtoEUR = amount33 * (eurEUR / eurJPY);
    //                    //double JPYtoGBP = amount33 * (eurGBP / eurJPY);
    //                    //Console.WriteLine($"1.{Math.Round(JPYtoUSD, 2)} USD;\n2.{Math.Round(JPYtoEUR, 2)} EUR;\n3.{Math.Round(JPYtoGBP, 2)} GBP.");
    //                    return (JPYtoUSD);
    //                //break;
    //                default:
    //                    Console.WriteLine("Ivede klaida. Bandykite dar karta.");
    //                    break;
    //            }
    //        }
    // public static double ConverterOfCurrency(string number, string currency)
    //{
    //    string inPut331 = "100";
    //    string inPut332 = "USD";
    //    double amount33 = Convert.ToDouble(inPut331);
    //    string cur33 = inPut332.ToUpper();
    //    double eurUSD = 1.0886;
    //    double eurEUR = 1.0000;
    //    double eurGBP = 0.8592;
    //    double eurJPY = 159.15;
    //    switch (cur33)
    //    {
    //        case "USD":
    //            double USDtoEUR = amount33 / eurUSD;
    //            return (USDtoEUR);
    //        case "EUR":
    //            double EURtoUSD = amount33 * eurUSD;
    //            return (EURtoUSD);
    //        case "GBP":
    //            double GBPtoEUR = amount33 * (eurEUR / eurGBP);
    //            return (GBPtoEUR);
    //        case "JPY":
    //            double JPYtoUSD = amount33 * (eurUSD / eurJPY);
    //            return (JPYtoUSD);
    //    }

}