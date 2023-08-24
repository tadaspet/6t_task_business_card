//string myText = "text";

//int myIndexLength = myText.Length;
//myIndexLength = +2;
//Console.WriteLine(myIndexLength);
#region Integer to String
//string myText1 = "82";
//string myText2 = "2";
//Console.WriteLine(myText1 + myText2); //822

//int myInt1 = 82;
//int myInt2 = 2;
//Console.WriteLine(myInt1 + myInt2); // 84

//string s = "" + myInt1;  //"82"
//string myIntConverted1 = myInt1.ToString(); // "82"

//string myIntConverted1 = Convert.ToString(myInt1); // "82"
//string myIntConverted2 = Convert.ToString(myInt2);
//Console.WriteLine(myIntConverted1 + myIntConverted2);

#endregion

//Converting strings to integers:
string sNumber1 = "2";
string sNumber2 = "5";
int stringNumber1AsInt = Convert.ToInt32(sNumber1);
int stringNumber2AsInt = Convert.ToInt32(sNumber2);
Console.WriteLine(sNumber1 + sNumber2);
Console.WriteLine(stringNumber1AsInt + stringNumber2AsInt);