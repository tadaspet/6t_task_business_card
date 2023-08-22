//string firstline = "vienas";
//string secondline = "du";

////int firstnumber = 3;
////int secondnumber = 2;
////firstnumber /= secondnumber; // veikia visi arimetriniai vieksmai 
////console.writeline(firstnumber);

////firstline = firstline + secondline;
//firstline += secondline; //atsakymas "vienasdu"

//string thirdline = firstline + secondline;
//console.writeline(thirdline);

//console.writeline(firstline); //atsakymas "vienasdu"


//string firstLine = "vienas";
//string secondLine = "du";


//string city = "Šiauliai";
//int wordLength = "Šiauliai".Length;
//int wordLength = city.Length;
//Console.WriteLine(wordLength);



// kiti konstruktoriai//////////////
//char[] characters = { 'c', 's', 'h', 'a', 'r', 'p' }; //char array
//string word = new string(characters);
//Console.WriteLine(word);

//string word1 = "mama";
//Console.WriteLine("first text: " + word1);
////string word2 = word1.Replace('m', 'p');
//string word2 = word1.Replace('m', 'p').Replace('a', 'u');
//Console.WriteLine(word2);
//word2 = word2.Replace('p', 't');
//Console.WriteLine(word2);

//string word44 = "Šiauliai";
//char firsletter = word44[4];
//Console.WriteLine(firsletter);

char[] characters = { 'S', 'i', 'a', 'u', 'l', 'i', 'a', 'i' };
string city = new string(characters);
char letter = city[6];
int cityLength = city.Length;
Console.WriteLine("String text: " + city);
Console.WriteLine("String Index 4: " + letter);
Console.WriteLine("Text length: " + cityLength);



