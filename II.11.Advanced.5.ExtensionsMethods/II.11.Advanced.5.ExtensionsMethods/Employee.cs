using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._11.Advanced._5.ExtensionsMethods
{
    public class Employee
    {
        private string alias; //fieldas
        private string name; //fieldas
        private int age;

        public int Age //properties
        {
            get
            {
                Console.WriteLine("Paimamas objekto age properties");
                return age;
            }
            private set
            {
                if (age > 0)
                {
                    age = value;
                }
            }
        }
        public static string Nationality { get; set; }
        public Employee(string alias, string name) 
        {
            this.alias = alias;     // su this priskiriama fieldui
            this.name = name;       // su this priskiriama fieldui
            age = 35;
            Nationality = "Lithuanian";     //negalime naudoti nes tai statininis properties
            SayHello();
            SayHelloStatic();       //negalime naudoti nes tai statininis metodas
        }
        public void SayHello()
        {
            Console.WriteLine("Sveiki");
        }
        public static void SayHelloStatic()
        {
            Console.WriteLine("Sveiki is statinio metodo");
        }
    }

}
