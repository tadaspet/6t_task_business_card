public static class CharArray
{
    public static void Main(string[] args)
    {

    }

    #region Example 1
    //string text = "Labas";
    //char[] characterArray = text.ToCharArray();
    //characterArray[2] = 'k';
    //string modText = new string(characterArray);
    //Console.WriteLine(modText);
    #endregion

    #region Access letter by index in string
    //string anotherText = "LaLabas";
    //char firstLetter = anotherText[0];
    //Console.WriteLine(anotherText);
    //Console.WriteLine(firstLetter);
    //anotherText = anotherText.Replace('L', 'R'); //changes all same letters no matter location in the array
    //Console.WriteLine(anotherText);
    #endregion

    #region String is Null or Empty
    //string text3 = " ";
    //Console.WriteLine(text3.Length);
    //if (string.IsNullOrEmpty(text3)) // checks if string has any characters
    //{
    //    Console.WriteLine("Stringas yra null arba tuscias");
    //}
    //else
    //{
    //    Console.WriteLine("Stringas yra ne tuscias");
    //}
    //if (string.IsNullOrWhiteSpace(text3))
    //{
    //    Console.WriteLine("Stringas yra tuscias arba su tarpais"); // Ignores there are spaces, new line "\n", "\r"
    //}
    //else
    //{
    //    Console.WriteLine("Stringas yra ne tuscias");
    //}
    #endregion

    #region TryParce text to numbers
    //string text = "-1";
    //int number;
    ////bool sucessConversion = int.TryParse(text, out number);
    //if(int.TryParse(text, out number)) // TryParce atitinka ir gali buti naudojama kaip bool salyga
    //{
    //    Console.WriteLine("Konvertavimas pavyko. Gautas skaicius: " + number);
    //}
    //else
    //{
    //    Console.WriteLine($"Ivestas tekstas nera skaicius.Klaida {number}");
    //}
    #endregion

    #region string operators examples
    //string text21 = "KodavimasACAD";
    //string text22 = "Kod";

    ////int compareTexts = text21.CompareTo(text22);
    ////Console.WriteLine(compareTexts);

    //if (text21.Contains(text22))
    //{
    //    Console.WriteLine($"Text contains {text22}");
    //}
    //else
    //{
    //    Console.WriteLine("Text does not contain");
    //}
    //if (text21.EndsWith(text22))
    //{
    //    Console.WriteLine($"Text ends with {text22}");
    //}
    //else
    //{
    //    Console.WriteLine("Text does not end with");
    //}
    //if (text21.StartsWith(text22))
    //{
    //    Console.WriteLine($"Text starts with {text22}");
    //}
    //else
    //{
    //    Console.WriteLine($"Text does not start with {text22}");
    //}
    //if (text21 == text22)
    //{
    //    Console.WriteLine("Texts are equal");
    //}
    //else
    //{
    //    Console.WriteLine("Texts are NOT equal");
    //}

    //int IndexOf = text21.IndexOf(text22);
    //Console.WriteLine($"Index of text22: {IndexOf}");

    //int LastIndexOf = text21.LastIndexOf(text22);
    //Console.WriteLine($"Index of text22: {LastIndexOf}");

    //Console.WriteLine($"Text to upper: {text21.ToUpper()}");
    //Console.WriteLine($"Text to lower: {text21.ToLower()}");

    //int stringLength = text21.Length;
    //Console.WriteLine($"Text length: {stringLength}");

    //char symbol21 = 'a';
    //int text21Count = text21.Count(x => x == symbol21);
    //Console.WriteLine($"Symbol repeated count in the text {text21Count}");

    //Console.WriteLine(text21.Remove(0, 9));

    //string old = "ACAD";
    //string newString = "old";
    //Console.WriteLine($"Text21 replaced by text22: {text21.Replace(old, newString)}");

    //string[] testArray = text21.Split("s");
    //Console.WriteLine(testArray[0]);
    //Console.WriteLine(testArray[1]);





    //int compareTexts = text21.CompareTo(text22);
    //Console.WriteLine(compareTexts);

    #endregion



    #region No 1.2
    //Console.WriteLine("======== 1.1 =========");
    //Console.WriteLine("Iveskite teksta:");
    //string inPut1 = Console.ReadLine();
    //char[] inPutArray = inPut1.ToCharArray();
    //inPutArray[0] = Char.ToUpper(inPutArray[0]);
    //Console.WriteLine(inPutArray);
    #endregion



    #region No 1.2
    //Console.WriteLine("======== 1.2 =========");
    //Console.WriteLine("Iveskite teksta:");
    //string inPut12 = Console.ReadLine();
    //char[] inPutArray12 = inPut12.ToCharArray();
    //inPutArray12[1] = 'g';
    //inPutArray12[3] = 'b';
    //inPutArray12[5] = '*';
    //inPutArray12[7] = 'x';
    //inPutArray12[9] = 'W';
    //Console.WriteLine(inPutArray12);
    #endregion

    #region No 1.3
    //Console.WriteLine("======== 1.2 =========");
    //Console.WriteLine("Iveskite teksta is 5 simboliu:");
    //string inPut13 = Console.ReadLine();
    //if (inPut13.Length != 5)
    //{
    //    Console.WriteLine("Tekstas nera 5 simboliu ilgio. Bandykite dar karta.");
    //}
    //else
    //{
    //    Console.WriteLine("Iveskite skaiciu sifravimui:");
    //    int codeNumber = Convert.ToInt32(Console.ReadLine());
    //    char[] textChar = inPut13.ToCharArray();
    //    textChar[0] = Convert.ToChar(Convert.ToInt32(textChar[0]) + codeNumber);
    //    textChar[1] = Convert.ToChar(Convert.ToInt32(textChar[1]) + codeNumber);
    //    textChar[2] = Convert.ToChar(Convert.ToInt32(textChar[2]) + codeNumber);
    //    textChar[3] = Convert.ToChar(Convert.ToInt32(textChar[3]) + codeNumber);
    //    textChar[4] = Convert.ToChar(Convert.ToInt32(textChar[4]) + codeNumber);
    //    Console.WriteLine($"Jusu uzsifruota fraze: {new string (textChar)}");
    //    Console.WriteLine(textChar);
    //}
    #endregion


    #region No 2.1
    //Console.WriteLine("======== 2.1 =========");
    //Console.WriteLine("Sakinio simboliu konvertavimas:");
    //string inPut21 = Console.ReadLine();
    //string aTouo = "uo";
    //string iToe = "e";
    //string inPut211 = inPut21.Replace("a", aTouo);
    //string inPut2111 = inPut211.Replace("i", iToe);
    //Console.WriteLine("Sukeistu simboliu sakinys:");
    //Console.WriteLine(inPut2111);
    #endregion

    #region No 2.2
    //Console.WriteLine("======== 2.2 =========");
    //Console.WriteLine("Iveskite ketureili:");
    //string inPut221 = Console.ReadLine();
    //string inPut222 = Console.ReadLine();
    //string inPut223 = Console.ReadLine();
    //string inPut224 = Console.ReadLine();
    //Console.WriteLine("Iveskite zodi kuri noretumete pakeisti:");
    //string inPutChange = Console.ReadLine();
    //Console.WriteLine("Iveskite nauja zodi:");
    //string inPuteReplace = Console.ReadLine();
    //string outPut221 = inPut221.Replace(inPutChange, inPuteReplace, StringComparison.InvariantCultureIgnoreCase);
    //string outPut222 = inPut222.Replace(inPutChange, inPuteReplace, StringComparison.InvariantCultureIgnoreCase);
    //string outPut223 = inPut223.Replace(inPutChange, inPuteReplace, StringComparison.InvariantCultureIgnoreCase);
    //string outPut224 = inPut224.Replace(inPutChange, inPuteReplace, StringComparison.InvariantCultureIgnoreCase);
    //Console.WriteLine($"Atnaujintas tekstas:\n{outPut221}\n{outPut222}\n{outPut223}\n{outPut224}");
    #endregion

    #region No 2.3
    //Console.WriteLine("======== 2.3 =========");
    //Console.WriteLine("Iveskite savo amziu:");
    //double inPut23 = Convert.ToDouble(Console.ReadLine());
    //double leftYears = 90 - inPut23;
    //double leftWeeks = (90 - inPut23) * (365.25 / 7);
    //double leftDays = (90 - inPut23) * (365.25);
    //Console.WriteLine($"Kad pasiekti 90 metu riba, Jus dar turite nugyventi - {leftYears} metu(s);\nTai taip pat lygu - {Math.Round(leftWeeks, 2)} savaitems;\nO dienu skaicius - {Math.Round(leftDays, 2)}!");
    //Console.WriteLine("Skaiciai yra suapavalintu iki sveikuju.\nMetai buvo prilyginti 365.25 dienos, del keliamuju.");
    #endregion

    #region No 3.1
    //Console.WriteLine("======== 3.1 =========");
    //Console.WriteLine("Iveskite savo zodi:");
    //string inPut31 = Console.ReadLine();
    //bool firstLetterUpper = Char.IsUpper(inPut31[0]);
    //if (firstLetterUpper)
    //{
    //    Console.WriteLine("Jusu zodzio pirma raide yra didzioji.");
    //    Console.WriteLine(inPut31.ToUpper());
    //}
    //else
    //{
    //    Console.WriteLine("Jusu zodzis prasidejo mazaja.");
    //    Console.WriteLine(inPut31.Substring(0,1).ToUpper() + inPut31.Substring(1));
    //}
    #endregion

    #region No 3.2
    public static string WordContainsALetter(string Word1)
    {
        //Console.WriteLine("======== 3.2 =========");
        //Console.WriteLine("Iveskite savo zodi:");
        //string inPut32 = Console.ReadLine();
        bool checkA = Word1.Contains('a');
        if (checkA)
        {
            //Console.WriteLine("Jusu ivestame zodyje yra raide 'a'.");
            //Console.WriteLine($"Zodzio likutis nuo pirmos 'a' raides - {inPut32.Substring(inPut32.IndexOf('a'))}");
            return "Jusu ivestame zodyje yra raide 'a'.";
        }
        else
        {
            //Console.WriteLine("Zodyje 'a' simbolis nerastas.");
            return "Zodyje 'a' simbolis nerastas.";
        }
    }
#endregion

#region No 3.3
public static string ReversedWord(string Word1)
    {
        //Console.WriteLine("======== 3.3 =========");
        //Console.WriteLine("Iveskite savo zodi:");
        //string inPut33 = Console.ReadLine();
        char[] revString = Word1.ToCharArray();
        Array.Reverse(revString);
        bool test33 = Word1 == "labas";
        if (test33)
        {
            //Console.WriteLine($"Atvirksciai butu - {new string(revString)}");
            return new string(revString);
        }
        else
        {
            //Console.WriteLine($"Jusu ivestas zodis '{Word1}' nebus apsuktas");
            return "Neapsuktas zodis.";
        }
    }
#endregion

#region No 4 NOt started
#endregion

#region No 5
//Console.WriteLine("======== 5 =========");
//Console.WriteLine("Iveskite telefono numeri");
//string inPut33 = Console.ReadLine();
//string[] numArray = { "+370", "+372", "+371", "+45", "+44", "+47", "+358", "+46", "+355", "+373", "+1"};
//string[] countryArray = {"LT", "EE", "LV", "DK", "UK/GB", "NO", "FI","SE", "AL", "MD", "JAV"};
//string code1 = inPut33.Substring(0, 4);
//string code2 = inPut33.Substring(0, 3);
//string code3 = inPut33.Substring(0, 2);
//Console.WriteLine("Kiek minuciu kalbesite?");
//double duration = Convert.ToDouble(Console.ReadLine());
//double price = 3;
//bool check0 = numArray.Any(inPut33.Contains);
//bool check1 = inPut33.Contains(code1);
//bool check2 = inPut33.Contains(code2);
//bool check3 = inPut33.Contains(code3);
//if (check0)
//{
//    if (check1)
//    {
//        int countryIndex1 = Array.FindIndex(numArray, x => code1.Contains(x));
//        Console.WriteLine("Operatorius - CodeAcademy;");
//        Console.WriteLine($"skambinote numeriu: {inPut33};");
//        Console.WriteLine($"Jus skambinote i sali : {countryArray[countryIndex1]} ");
//        Console.WriteLine($"Skambuciu laikas: {duration} min;");
//        Console.WriteLine($"Skambucio kaina {price}/1min;");
//        Console.WriteLine($"Galutine skambucio kaina: {duration * price}");
//    }
//    else if (check2)
//    {
//        int countryIndex2 = Array.FindIndex(numArray, x => code2.Contains(x));
//        Console.WriteLine("Operatorius - CodeAcademy;");
//        Console.WriteLine($"skambinote numeriu: {inPut33};");
//        Console.WriteLine($"Jus skambinote i sali : {countryArray[countryIndex2]}");
//        Console.WriteLine($"Skambuciu laikas: {duration} min;");
//        Console.WriteLine($"Skambucio kaina {price}/1min;");
//        Console.WriteLine($"Galutine skambucio kaina: {duration * price}");
//    }
//    else if (check3)
//    {
//        int countryIndex3 = Array.FindIndex(numArray, x => code3.Contains(x));
//        Console.WriteLine("Operatorius - CodeAcademy;");
//        Console.WriteLine($"skambinote numeriu: {inPut33};");
//        Console.WriteLine($"Jus skambinote i sali : {countryArray[countryIndex3]}");
//        Console.WriteLine($"Skambuciu laikas: {duration} min;");
//        Console.WriteLine($"Skambucio kaina {price}/1min;");
//        Console.WriteLine($"Galutine skambucio kaina: {duration * price}");
//    }
//}

#endregion
}

