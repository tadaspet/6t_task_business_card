using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class Menu
    {
        public bool GoBack { get; set; }
        public bool Return()
        {
            Thread.Sleep(1500);
            Console.WriteLine("Press any button to return back.");
            string inPut=Console.ReadLine();
            if (inPut != null)
            {
                Console.Clear();
                GoBack = true;
            }
            while (inPut != null)
            {
                Thread.Sleep(3000);
                Console.WriteLine("After 5 seconds information will be hidden.");
                Thread.Sleep(5000);
                Console.Clear();
                GoBack = true;
            }
            return GoBack;
        }
        //public static void MenuBackToPrevious(out bool quit)
        //{
        //    Console.WriteLine("\nPlease enter 'q' to go back.");
        //    string inPut = Console.ReadLine();
        //    while (inPut != "q")
        //    {
        //        Console.WriteLine("Please enter 'q' to go back.");
        //        inPut = Console.ReadLine();
        //    }
        //    quit = true;
        //    Console.Clear();
        //}
    }
}
