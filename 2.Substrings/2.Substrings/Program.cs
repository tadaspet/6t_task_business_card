//string word1 = "CodeAcademy";
//string sub1word1 = word1.Substring(2, 3);
//string sub2word1 = word1.Substring(2);
//Console.WriteLine("Full text: " + word1);
//Console.WriteLine("Substring(2,3): " + sub1word1);
//Console.WriteLine("Substring(2,3): " + sub2word1);

#region task #2
//string s = "Mano vardas yra Tadas";
//string name = s.Substring(16);
//string my = s.Substring(0, 4);
//Console.WriteLine("Task text: " + s);
//Console.WriteLine(name);
//Console.WriteLine(my);



//string s = "Mano vardas yra Tadas";
//Console.WriteLine("Task text is: "+ s);
//Console.WriteLine(s.Substring(16));
//Console.WriteLine(s.Substring(0, 4));
#endregion

string name = "CodeAcademy";
int indexOfC = name.IndexOf("c");
int indexOfd = name.IndexOf("d");
int indexOfAcademy = name.IndexOf("Academy");
int indexOfd3 = name.IndexOf("d",3);
int indexOfPirm = name.IndexOf("Pirmadienis");
int indexOfe = name.LastIndexOf("e");
Console.WriteLine(indexOfC);
Console.WriteLine(indexOfd);
Console.WriteLine(indexOfAcademy);
Console.WriteLine(indexOfd3);
Console.WriteLine(indexOfPirm);
Console.WriteLine(indexOfe);

