//bool isLogged = false;
//if (isLogged)
//    Console.WriteLine("Jus esate prisijunges");
//else Console.WriteLine("neprisijunges");



//int number = 6;
//bool isNumber5 = number == 5;
//if (isNumber5)
//    Console.WriteLine("Skaicius yra 5");
//if (number > 0)
//    Console.WriteLine("Skaicius yra teigiamas");


// Nested IF's


#region Double if example
//int age = 17;
//bool hasLicense = true;

//if (age >= 18)
//{
//    Console.WriteLine("Jus esate pilanametis");

//    if (hasLiicense)
//    {
//        Console.WriteLine("Jus turite teise vairuoti");
//    }
//    else
//    {
//        Console.WriteLine("Jus nevairuojate");
//    }
//}
//else
//{
//    Console.WriteLine("Nepilnametis");
//}
#endregion


#region Logical operators
////////// AND operator "&&" ///////////////////////////
//int age = 18;
//bool hasLicense = true;

//if(age >= 18 && hasLicense)
//{
//    Console.WriteLine("Jus turite teise vairuoti");
//}


///////// OR operator "||" ////////////////////////////////
//string userInput = Console.ReadLine();
//if(userInput == "admin" ||  userInput == "administrator")
//{
//    Console.WriteLine("Jus turite Administratoriaus prieiga");
//}


///////// COMBINING "&&' and "||" /////////////////////////
//int age = 65;
//bool hasLicense = true;

//if ((age >= 18 && hasLicense) || age>= 65)
//{
//    Console.WriteLine("Jus turite teise vairuoti arba jms priklauso pensija");
//}

//// && (both statements have to be true)
//// true && true = true
//// true && false = false 
//// false && true = false
//// faalse && false = false

//// || at least one statements msut be true
//// true || true = true
//// true || fase = true
//// false || true = true
//// false || false = false

#endregion