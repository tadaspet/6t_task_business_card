using System.Net.Http.Headers;

Console.WriteLine("=======LabirintAvimas========");
int attLevel;
int damLevel;
int health;
Random random = new Random();
int paperCissStone3 = random.Next(1, 3);
int charLev = random.Next(0, 4);
string[] damageLevel = { "Dumb", "Simple-minded", "Average", "Intelligent", "Brilliant" };
string[] attackMet = { "1.Stone", "2.Scissors", "3.Paper" };
string[] directPath = { "1.North", "2.East", "3.South", "4.West" };
string[] pathDescrip = { "You chose The North path of mystical lands, ice wizards, enchanted forests.", "You chose The East path of sunrise quests, ancient sorcerers, magical artifacts.", "You chose The South path of hidden treasures, dragon lairs, mystical creatures.", "You chose The West path of sunset adventures, fairy realms, mystical powers. " };
Console.WriteLine("Type in your name:");
string name = Console.ReadLine();
Console.WriteLine("Write No of your World direction:");
Console.WriteLine($"{directPath[0]}\n{directPath[1]}\n{directPath[2]}\n{directPath[3]}");
int path1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
switch (path1)
{
    case 1:
        Console.WriteLine(pathDescrip[0]); 
        break;
    case 2:
        Console.WriteLine(pathDescrip[1]);
        break;
    case 3:
        Console.WriteLine(pathDescrip[2]);
        break;
    case 4:
        Console.WriteLine(pathDescrip[3]);
        break;
    default: Console.WriteLine("Make Decision One More Time!");
        break;
}
//some shapes from the while excersies for 100 rows (2 sec)
//Console.Clear();
Console.WriteLine($"You have approached a {damageLevel[charLev]} level Wizard!\nIn order to continue you must out smart him in a simple game!");
Console.WriteLine($"Make your choice:\n{attackMet[0]}\n{attackMet[1]}\n{attackMet[2]}");
int userAttack1;
int wizAttack1;

do
{
    userAttack1 = Convert.ToInt32(Console.ReadLine());
    wizAttack1 = random.Next(1, 3);
    Console.WriteLine($"Wizard showed the {attackMet[wizAttack1 -1].Substring(2)}");
    switch (userAttack1)
    {
        case 1:
            if (wizAttack1 == 1)
            {
                Console.WriteLine("You were Neck to Neck.");
            }
            else if (wizAttack1 == 2)
            {
                Console.WriteLine("You Smarter than you look!");
            }
            else if (wizAttack1 == 3)
            {
                Console.WriteLine("It was not your time.....");
            }
            break;
        case 2:
            if (wizAttack1 == 1)
            {
                Console.WriteLine("It was not your time.....");
            }
            else if (wizAttack1 == 2)
            {
                Console.WriteLine("You were Neck to Neck.");
            }
            else if (wizAttack1 == 3)
            {
                Console.WriteLine("You Smarter than you look!");
            }
            break;
        case 3:
            if (wizAttack1 == 1)
            {
                Console.WriteLine("You Smarter than you look!");
            }
            else if (wizAttack1 == 2)
            {
                Console.WriteLine("It was not your time.....");
            }
            else if (wizAttack1 == 3)
            {
                Console.WriteLine("You were Neck to Neck." +
                    "");
            }
            break;
    }

}while(userAttack1 == wizAttack1);





