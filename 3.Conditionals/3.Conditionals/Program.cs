//bool myTrueVariable = true;
//bool myFlaseVariable = false;

//int age = 18;
//if(age == 18) // equals condition
//{
//    Console.WriteLine("Jus esate 18 met amziaus");
//}

//int number = 10;
//if(number != 0)  // not equal condition  
//{
//    Console.WriteLine($"Skaicius nelygus nulis, o skaicius yra {number}");
//}

//int score = 98; // less condition
//if(score < 90)
//{
//    Console.WriteLine($"Jusu rezultatas ya mazesnis nei 90, skaicius yra {score}");
//}
//if(score > 90) // more condition
//{
//    Console.WriteLine($"Jusu rezultatas ya didesnis nei 90, skaicius yra {score}");
//}
//if  (score <= 90) //less or equal condition
//{
//    Console.WriteLine($"Jusu rezultatas 90 arba maziau, skaicius {score}");
//}
//if (score >= 90)
//{
//    Console.WriteLine($"Jus rezultatas 90 arba duagiau, skacius {score}");
//}

// ==  - equal
// !=  - not equal
// <   - less
// <=  - less or equal
// >   - more
// >=  - more or equal


//int no = 10;
//if (no > 0)
//{
//    Console.WriteLine($"Skaicius yra teigimas.(verte {no})");
//}
//else if(no < 0)
//{
//    Console.WriteLine($"Skaicius yra neigiams. (verte {no})");
//}
//else
//{
//    Console.WriteLine($"Skaicius yra nulis. (verte {no})");
//}


//int howMchMoneyIHave = 20;
//int myBasketTotal = 15;
//if (howMchMoneyIHave >= myBasketTotal)
//{
//    Console.WriteLine("As turiu pakankamai pinigu");
//}
//else
//{
//    Console.WriteLine("Neturiu pakankmai");
//}



#region no1.1 task
//Console.WriteLine("Please, input the number: ");
//string number100 = Console.ReadLine();
//int number1 = Convert.ToInt32(number100);
//Console.WriteLine($"Input number is: {number1}");
//if (number1 > 100)
//{
//    Console.WriteLine("The number is higher than 100");
//}
//else if (number1 == 100)
//{
//    Console.WriteLine("The number is equal to 100");
//}

//else
//{
//    Console.WriteLine("The number is less than 100");
//}
#endregion


#region no1.2 task
//Console.WriteLine("===========================");
//Console.WriteLine("please, input the week day number: ");
//string wno = Console.ReadLine();
//int inputno = Convert.ToInt32(wno);
//Console.WriteLine($"input week number is: {inputno}");
//if (inputno == 1)
//    Console.WriteLine("it is monday (1)");
//else if (inputno == 2)
//    Console.WriteLine("it is tuesday (2)");
//else if (inputno == 3)
//    Console.WriteLine("it is wednesday (3)");
//else if (inputno == 4)
//    Console.WriteLine("it is thursday (4)");
//else if (inputno == 5)
//    Console.WriteLine("it is friday (5)");
//else if (inputno == 6)
//    Console.WriteLine("it is saturday (6)");
//else if (inputno == 7)
//    Console.WriteLine("it is sunday (7)");
//else Console.WriteLine("input number does not match weekday");
#endregion


#region no2.1 task
Console.WriteLine("===========================");
//Console.WriteLine("Please, input number to check: ");
//string no3 = Console.ReadLine();
//int inputNo3 = Convert.ToInt32(no3);
//Console.WriteLine($"Input number is: {inputNo3}");
//int evenNo2 = inputNo3 % 2;
//int fiveNo2 = inputNo3 % 5;
//if (evenNo2 == 0)
//    Console.WriteLine("Number is dividing by 2");
//else if (fiveNo2 == 0)
//    Console.WriteLine("Number is divinding by 5");
//else
//    Console.WriteLine("Number is not dividing by 2 or 5");
#endregion


#region No2.2 ask
//Console.WriteLine("===========================");
//Console.WriteLine("Please, input temperature by Celcius: ");
//string temp = Console.ReadLine();
//int inputTemp = Convert.ToInt32(temp);
//Console.WriteLine($"Input Temperature is: {inputTemp}");
//if (inputTemp < 0)
//    Console.WriteLine($"Temperature {inputTemp} is VERY COLD");
//else if (0 <= inputTemp && inputTemp <= 20)
//    Console.WriteLine($"Temperature {inputTemp} is CHILL");
//else Console.WriteLine($"Temperature {inputTemp} is HOT");

#endregion


#region no3.1 task
//Console.WriteLine("===========================");
//Console.WriteLine("Please, input hour TIME in 24' format: ");
//string h1 = Console.ReadLine();
//int inputH3 = Convert.ToInt32(h1);
//Console.WriteLine($"Input Time number is: {inputH3}");
//if (inputH3 < 12 && inputH3 >= 0)
//    Console.WriteLine($"Have Good Morning it is {inputH3} hours");
//else if (inputH3 >= 12 && inputH3 <= 18)
//    Console.WriteLine($"Have Good Day it is {inputH3} hours");
//else if (inputH3 > 18 && inputH3 <= 24)
//    Console.WriteLine($"Have Good Evening it is {inputH3} hours");
//else Console.WriteLine($"There is no such time");
#endregion


#region no3.2 task
//Console.WriteLine("===========================");
//Console.WriteLine("Please, input your password: ");
//string pass = Console.ReadLine();
//if (pass == "123456")
//    Console.WriteLine("Login Succesfull");
//else if (pass == "01101001 01101110")
//    Console.WriteLine("You broke in");
//else if (pass == "Mellon")
//    Console.WriteLine("Login Succesfull");
//else Console.WriteLine("Password is wrong, try one more time");
#endregion


// NOT= !
// AND = &&
// OR = ||
// XOR = ^  (It ensures that either A or B is true but never both)