namespace _09.Advanced.Generics3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"a","b","c","d", "g", "h","b" };
            var readOnly = new ReadOnly<string>(list);
            readOnly.PrintList();
            readOnly.ListToArray();
            readOnly.ReturnOneValue("a");
            Console.WriteLine("-----------");
            string question = readOnly.ReturnMatch("z");
            Console.WriteLine(question);

            Console.WriteLine(readOnly.ReturnMatchCheck("a"));


            List<int> list2 = new List<int> { 2,3,4,5,6,7,8,9,1,0,1,2,3,4,5,6,7 };
            var readOnly2 = new ReadOnly<int>(list2);
            Console.WriteLine("-----------");
            int test = readOnly2.ReturnMatch(12);
            Console.WriteLine(test);
            int test2 = readOnly2.ReturnMatch(9);
            Console.WriteLine(test2);
        }
    }
}