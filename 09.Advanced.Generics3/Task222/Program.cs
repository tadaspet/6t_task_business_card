namespace Task222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newGeneric = new GenericClass<int>();
            List<int> list = new List<int> {1,2,2,4,4,6,6,6,8,9,10,10,3,17,18,16,14,12,11,10 };
            newGeneric.MainList = list;
            newGeneric.PrintList();
            int[] first = newGeneric.ConverToArray();
            newGeneric.AddToOneValueList(100);
            Console.Clear();
            newGeneric.PrintList();
            List<int> newInts = new List<int> { 100,200,300,400};
            newGeneric.AddListToList(newInts);
            newGeneric.PrintList();
            //newGeneric.RemoveElementFromList(100);
            newGeneric.PrintList();
            newGeneric.RemoveIndexFromList(3);
            newGeneric.PrintList();
            newGeneric.RemoveSameItemsFromList(10);
            newGeneric.PrintList();
        }
    }
}