#region No.4
//Console.WriteLine("=====TASK 4=====");
//Console.WriteLine("Amziaus patikra, iveskite amziu:");
//string age = Console.ReadLine();
//int ageTest = Convert.ToInt32(age);
//bool teen = ageTest < 18;
//bool adult = (ageTest >= 18 && ageTest < 65);
//bool old = ageTest >= 65;

//if (teen)
//{
//    Console.WriteLine("Jums priklauso nepilnamecio akcija");
//}
//if (adult)
//{
//    Console.WriteLine("Jus esate suauges");
//}
//if (old)
//{
//    Console.WriteLine("Jums priklauso senjoro akcija");
//}
#endregion


#region No 5
//Console.WriteLine("=====TASK 5=====");
//Console.WriteLine("Patikrinsiu ar tai yra keliamieji metai, iveskite metus:");
//string age5 = Console.ReadLine();
//int age5Test = Convert.ToInt32(age5);
//int div4 = age5Test % 4;
//int div100 = age5Test % 100;
//int div400 = age5Test % 400;
//if ((div4 == 0 && div100 != 0) || div400 == 0)
//{
//    Console.WriteLine("Tai yra keliamieji metai");
//}
//else
//{
//    Console.WriteLine("Tai nera keliamieji metai");
//}
#endregion


#region No 6
Console.WriteLine("=======TASK 6=======");
int[] prices = new int[7] { 1200, 150, 400, 140, 130, 100, 120 };
string[] texts = new string[7] { "Kompiuteris", "Pakrovejas", "Monitorius", "Pele", "Klaviatura", "Kamera", "Laidai" };
Console.WriteLine("Isirinkite 3 prekiu krepseli is zemiau parodytu 7 produktu:");
Console.WriteLine($"1.{texts[0]} - {prices[0]}$;\n2.{texts[1]} - {prices[1]}$;\n3.{texts[2]} - {prices[2]}$;\n4.{texts[3]} - {prices[3]}$;\n5.{texts[4]} - {prices[4]}$;\n6.{texts[5]} - {prices[5]}$;\n7.{texts[6]} - {prices[6]}$;");
Console.WriteLine("Iveskite 3 prekiu numerius:");
string shop1 = Console.ReadLine();
string shop2 = Console.ReadLine();
string shop3 = Console.ReadLine();
int sel1 = Convert.ToInt32(shop1);
int sel2 = Convert.ToInt32(shop2);
int sel3 = Convert.ToInt32(shop3);
bool outRange = ((sel1 < 1 || sel2 < 1 || sel3 < 1) || (sel1 > 7 || sel2 > 7 || sel3 > 7));
bool equal3 = (sel1 == sel2) && (sel2 == sel3) && (sel1 == sel3);
bool equals12 = (sel1 == sel2 && sel1 != sel3);
bool equals23 = (sel2 == sel3 && sel2 != sel1);
bool equals13 = (sel1 == sel3 && sel1 != sel2);
bool unequal = ((sel1 != sel2) && (sel1 != sel3) && (sel2 != sel3));
if (equal3 && !outRange)
{
    double subTotal33 = (prices[sel1 - 1] * 3);
    double subTotal3 = (prices[sel1 - 1] * 3) * .85;
    double dis3 = subTotal3 * .1;
    double Total3 = subTotal3 - dis3;
    Console.WriteLine("Jus pasirinkote 3 vienodas prekes:");
    Console.WriteLine($"1.{texts[sel1 - 1]} - {prices[sel1-1]}$,\n2.{texts[sel1 - 1]} - {prices[sel1 - 1]}$,\n3.{texts[sel1 - 1]} - {prices[sel1 - 1]}$.");
    Console.WriteLine($"Bendra suma: {subTotal33}$.");
    Console.WriteLine($"Jums galioja akcija 3 vienodoms prekems!\nSuma su %15 nuolaida: {subTotal3}$.");
    Console.WriteLine("Ar turite lojalumo kortele? (Taip/Ne)");
    string loj1 = Console.ReadLine();
    if (loj1 == "Taip")
    {
        Console.WriteLine($"Lojalumo 10% nuolaida: {dis3}$.");
        Console.WriteLine($"Jusu moketina suma: {Total3}$.");
    }
    else if (loj1 == "Ne")
    {
        Console.WriteLine($"Jums neprytaikyta 10% lojalumo nuolaida: {dis3}$.");
        Console.WriteLine($"Jusu moketina suma: {subTotal3}$.");
    }
}
if (equals12 && !outRange)
{
    double subTotal23 = ((2 * prices[sel1 - 1]) + prices[sel3 - 1]);
    double dis2 = (2 * prices[sel1 - 1]) * .1;
    double subTotal2 = ((2 * prices[sel1 - 1]) + prices[sel3 - 1]) - dis2;
    double disTotal2 = subTotal2 * 0.1;
    double Total2 = subTotal2 - disTotal2;
    Console.WriteLine("Jus pasirinkote 2 vienodas prekes:");
    Console.WriteLine($"1.{texts[sel1 - 1]} - {prices[sel1 - 1]}$,\n2.{texts[sel2 - 1]} - {prices[sel2 - 1]}$,\n3.{texts[sel3 - 1]} - {prices[sel3 - 1]}$.");
    Console.WriteLine($"Bendra suma: {subTotal23}$.");
    Console.WriteLine($"Jums galioja akcija 2 vienodoms prekems!\nSuma su %10 nuolaida 2 pirmoms prekems: {subTotal2}$.");
    Console.WriteLine("Ar turite lojalumo kortele? (Taip/Ne)");
    string loj1 = Console.ReadLine();
    if (loj1 == "Taip")
    {
        Console.WriteLine($"Lojalumo 10% nuolaida: {disTotal2}$.");
        Console.WriteLine($"Jusu moketina suma: {Total2}$.");
    }
    else if (loj1 == "Ne")
    {
        Console.WriteLine($"Jums neprytaikyta 10% lojalumo nuolaida: {disTotal2}$.");
        Console.WriteLine($"Jusu moketina suma: {subTotal2}$.");
    }
}
if (equals23 && !outRange)
{
    double subTotal22 = ((2 * prices[sel2 - 1]) + prices[sel1 - 1]);
    double dis2 = (2 * prices[sel2 - 1]) * .1;
    double subTotal2 = ((2 * prices[sel2 - 1]) + prices[sel1 - 1]) - dis2;
    double disTotal2 = subTotal2 * 0.1;
    double Total2 = subTotal2 - disTotal2;
    Console.WriteLine("Jus pasirinkote 2 vienodas prekes:");
    Console.WriteLine($"1.{texts[sel1 - 1]} - {prices[sel1 - 1]}$,\n2.{texts[sel2 - 1]} - {prices[sel2 - 1]}$,\n3.{texts[sel3 - 1]} - {prices[sel3 - 1]}$.");
    Console.WriteLine($"Bendra suma: {subTotal22}$.");

    Console.WriteLine($"Jums galioja akcija 2 vienodoms prekems!\nSuma su %10 nuolaida: {subTotal2}$.");
    Console.WriteLine("Ar turite lojalumo kortele? (Taip/Ne)");
    string loj1 = Console.ReadLine();
    if (loj1 == "Taip")
    {
        Console.WriteLine($"Lojalumo 10% nuolaida: {disTotal2}$.");
        Console.WriteLine($"Jusu moketina suma: {Total2}$.");
    }
    else if (loj1 == "Ne")
    {
        Console.WriteLine($"Jums neprytaikyta 10% lojalumo nuolaida: {disTotal2}$.");
        Console.WriteLine($"Jusu moketina suma: {subTotal2}$.");
    }
}
if (equals13 && !outRange)
{
    double subTotal21 = ((2 * prices[sel1 - 1]) + prices[sel2 - 1]);
    double dis2 = (2 * prices[sel1 - 1]) * .1;
    double subTotal2 = ((2 * prices[sel1 - 1]) + prices[sel2 - 1]) - dis2;
    double disTotal2 = subTotal2 * 0.1;
    double Total2 = subTotal2 - disTotal2;
    Console.WriteLine("Jus pasirinkote 2 vienodas prekes:");
    Console.WriteLine($"1.{texts[sel1 - 1]} - {prices[sel1 - 1]}$,\n2.{texts[sel2 - 1]} - {prices[sel2 - 1]}$,\n3.{texts[sel3 - 1]} - {prices[sel3 - 1]}$.");
    Console.WriteLine($"Bendra suma: {subTotal21}$.");
    Console.WriteLine($"Jums galioja akcija 2 vienodoms prekems!\nSuma su %10 nuolaida: {subTotal2}$.");
    Console.WriteLine("Ar turite lojalumo kortele? (Taip/Ne)");
    string loj1 = Console.ReadLine();
    if (loj1 == "Taip")
    {
        Console.WriteLine($"Lojalumo 10% nuolaida: {disTotal2}$.");
        Console.WriteLine($"Jusu moketina suma: {Total2}$.");
    }
    else if (loj1 == "Ne")
    {
        Console.WriteLine($"Jums neprytaikyta 10% lojalumo nuolaida: {disTotal2}$.");
        Console.WriteLine($"Jusu moketina suma: {subTotal2}$.");
    }
}
if (unequal && !outRange)
{
    double subTotal0 = prices[sel1 - 1] + prices[sel2 - 1] + prices[sel3 - 1];
    double disTotal0 = subTotal0 * 0.1;
    double Total0 = subTotal0 - disTotal0;
    Console.WriteLine("Jus pasirinkote 3 skirtingas prekes:");
    Console.WriteLine($"1.{texts[sel1 - 1]} - {prices[sel1 - 1]}$,\n2.{texts[sel2 - 1]} - {prices[sel2 - 1]}$,\n3.{texts[sel3 - 1]} - {prices[sel3 - 1]}$.");
    Console.WriteLine($"Bendra suma: {subTotal0}$.");
    Console.WriteLine("Ar turite lojalumo kortele? (Taip/Ne)");
    string loj1 = Console.ReadLine();
    if (loj1 == "Taip")
    {
        Console.WriteLine($"Lojalumo 10% nuolaida: {disTotal0}$.");
        Console.WriteLine($"Jusu moketina suma: {Total0}$.");
    }
    else if (loj1 == "Ne")
    {
        Console.WriteLine($"Jums neprytaikyta 10% lojalumo nuolaida: {disTotal0}$.");
        Console.WriteLine($"Jusu moketina suma: {subTotal0}$.");
    }
}
if (outRange)
{
    Console.WriteLine("Vienas ar daugiau pasirinkimu neatitinka, prekiu krepselio!\nBandykite dar karta paleisti programa.");
}
#endregion


#region No 7
//Console.WriteLine("=====TASK 7=====");
//Console.WriteLine("'BazingaPop' patikrinimas, iveskite skaiciu:");
//string inPutText = Console.ReadLine();
//int noCheck = Convert.ToInt32(inPutText);
//int div3 = noCheck % 3;
//int div5 = noCheck % 5;
//if (div3 == 0 && div5 == 0)
//{
//    Console.WriteLine("BazingaPop");
//}
//else if (div3 == 0)
//{
//    Console.Write("Bazinga");
//}
//else if (div5 == 0)
//{
//    Console.WriteLine("Pop");
//}
//else
//{
//    Console.WriteLine($"Jusu skaicius {noCheck}");
//}
#endregion

#region No 8.1
//Console.WriteLine("=====TASK 8.1=====");
//Console.WriteLine("Tikrinimas ar 2 ivesti skaiciai yra teigiami, iveskite pirma skaiciu:");
//string inPutNo1 = Console.ReadLine();
//Console.WriteLine("Iveskite 2 skaiciu:");
//string inPutNo2 = Console.ReadLine();
//int plus1 = Convert.ToInt32(inPutNo1);
//int plus2 = Convert.ToInt32(inPutNo2);
//bool check1 = plus1 > 0;
//bool check2 = plus2 > 0;
//if (check1 && check2)
//{
//    Console.WriteLine("Abu skaiciai yra teigiami");
//}
//else if (check1 || check2)
//{
//    Console.WriteLine("Tik vienas skaicius yra teigiamas");
//}
//else
//{ 
//    Console.WriteLine("Ne vienas skaicius nera teigiamas");
//}
#endregion

#region No 8.2
//Console.WriteLine("=====TASK 8.2=====");
//Console.WriteLine("Lygiu skaiciu tikrinimas, iveskite pirma skaiciu:");
//string inPutNo1 = Console.ReadLine();
//Console.WriteLine("Iveskite 2 skaiciu:");
//string inPutNo2 = Console.ReadLine();
//Console.WriteLine("Iveskite 3 skaiciu:");
//string inPutNo3 = Console.ReadLine();
//int no1 = Convert.ToInt32(inPutNo1);
//int no2 = Convert.ToInt32(inPutNo2);
//int no3 = Convert.ToInt32(inPutNo3);
//bool equal3 = ((no1 == no2) && (no1 == no3) && (no2 == no3));
//bool equal2 = ((no1 == no2) || (no1 == no3) || (no2 == no3));
//if (equal3)
//{
//    Console.WriteLine("Visi skaiciai lygus");
//}
//else if (equal2)
//{
//    Console.WriteLine("Du skaiciai lygus");
//}
//else
//{
//    Console.WriteLine("Ne vienas skaicius nera lygus");
//}
#endregion

#region 9.1
//Console.WriteLine("=====TASK 9.1=====");
//Console.WriteLine("Tegiamu skaiciu 'a, b, c' sumos tikrinimas, iveskite pirma a skaiciu:");
//string inPutNo1 = Console.ReadLine();
//Console.WriteLine("Iveskite b skaiciu:");
//string inPutNo2 = Console.ReadLine();
//Console.WriteLine("Iveskite c skaiciu:");
//string inPutNo3 = Console.ReadLine();
//int no1 = Convert.ToInt32(inPutNo1);
//int no2 = Convert.ToInt32(inPutNo2);
//int no3 = Convert.ToInt32(inPutNo3);
//bool equal21 = (no1 > 0 && no2 > 0);
//bool equal22 = (no1 > 0 && no3 > 0);
//bool equal23 = (no2 > 0 && no3 > 0);
//bool equal3 = (no3 > 0 && no2 >0 && no1 > 0);
//int sum21 = no1 + no2;
//int sum22 = no2 + no3;
//int sum23 = no2 + no3;
//int sum3 = no3 + no2 + no1;
//if (equal3)
//{
//    Console.WriteLine($"Skaicius 'a','b' ir 'c' yra teigiami. Ju suma {sum3}");
//}
//else if (equal21)
//{
//    Console.WriteLine($"Skaicius 'a' ir 'b' yra teigiami. Ju suma {sum21}");
//}
//else if (equal22)
//{
//    Console.WriteLine($"Skaicius 'a' ir 'c' yra teigiami. Ju suma {sum22}");
//}
//else if (equal23)
//{
//    Console.WriteLine($"Skaicius 'b' ir 'c' yra teigiami. Ju suma {sum23}");
//}
//else
//{
//    Console.WriteLine("Nimanoma suskaiciuoti sumos");
//}
#endregion

#region No 9.2
//Console.WriteLine("=====TASK 9.2=====");
//Console.WriteLine("Iveskite metus ir menesi (pvz:2000-01):");
//string inPutNo1 = Console.ReadLine();
//string year = inPutNo1.Substring(0, 4);
//string month = inPutNo1.Substring(5);
//int yearNo = Convert.ToInt32(year);
//int monthNo = Convert.ToInt32(month);
//bool monthWinter = (monthNo > 0 && monthNo < 4);
//bool monthSummer = (monthNo > 6 && monthNo < 9);
//bool monthTerminal = (monthNo < 0 || monthNo > 12);
//bool monthAverage = (monthNo > 3 && monthNo < 7) || (monthNo > 8 && monthNo < 13);
//if (monthTerminal)
//{
//    Console.WriteLine($"Tokio menesio nera.");
//}
//else if (monthWinter)
//{
//    Console.WriteLine($"Saltas {yearNo} metu laikotarpis");
//}
//else if (monthSummer)
//{
//    Console.WriteLine($"Karstas {yearNo} metu laikotarpis");
//}
//else if (monthAverage)
//{
//    Console.WriteLine($"Vidutinis {yearNo} metu laikotarpis");
//}
#endregion

#region No 10
//Console.WriteLine("=====TASK 10=====");
//Console.WriteLine("Iveskite 3 skaicius ir gausite atsakyma ar jie galetu sudaryti trikampi, pirmas skaicius:");
//string inPutNo1 = Console.ReadLine();
//Console.WriteLine("Iveskite 2 skaiciu:");
//string inPutNo2 = Console.ReadLine();
//Console.WriteLine("Iveskite 3 skaiciu:");
//string inPutNo3 = Console.ReadLine();
//int no1 = Convert.ToInt32(inPutNo1);
//int no2 = Convert.ToInt32(inPutNo2);
//int no3 = Convert.ToInt32(inPutNo3);
//int sum1 = no1 + no2;
//int sum2 = no2 + no3;
//int sum3 = no3 + no1;
//bool equal = ((sum1 > no3) && (sum2 > no1) && (sum3 > no2));
//if (equal)
//{
//    Console.WriteLine("Galima sudaryti trikampi");
//}
//else
//{
//    Console.WriteLine("Negalima sudaryti trikampio");
//}
#endregion