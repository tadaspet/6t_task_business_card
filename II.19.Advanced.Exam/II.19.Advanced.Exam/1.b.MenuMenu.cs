using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace II._19.Advanced.Exam
{
    internal class MenuMenu
    {
        public List<MenuItem> MenuList { get; set; } = new List<MenuItem>();
        const string filePath = "C:\\NETUA2 class exercises\\03112023 Exam Menu\\Menu.txt";
        public List<MenuItem> ReadMenuFile()
        {
            var menuCreate = new List<MenuItem>();
            string line = "";
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        var separate = line.Split(',');
                        if (separate.Length == 4)
                        {
                            var menuItem = new MenuItem
                            {
                                SequenceNo = int.Parse(separate[0]),
                                MealName = separate[1],
                                MealPrice = double.Parse(separate[2]),
                                Type = separate[3],
                            };
                            menuCreate.Add(menuItem);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            MenuList = menuCreate;
            return MenuList;

        }
        public void PrintMenu()
        {
            var menuList = ReadMenuFile();
            var firstType = menuList[0].Type;
            string startSymb = "*";
            Console.WriteLine("----------------MENU----------------\n\n" + startSymb + " " + firstType + " " + startSymb);
            int count = 1;
            string extraSymb = "*";
            foreach (var menuItem in menuList)
            {
                if (menuItem.Type != firstType)
                {
                    firstType = menuItem.Type;
                    count++;
                    extraSymb += startSymb;
                    Console.WriteLine();
                    Console.WriteLine(extraSymb + " " + firstType + " " + extraSymb);
                }
                Console.WriteLine(menuItem.SequenceNo + "." + " " + menuItem.MealName + " " + Math.Round(menuItem.MealPrice,2) + " Eur.");
            }
        }
    }
}
