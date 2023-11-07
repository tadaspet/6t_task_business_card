using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._19.Advanced.Exam
{
    internal class Order : MenuMenu, IOrderCheck
    {
        public List<MenuItem> MenuList { get; set; }
        public List<OrderItem> Items {  get; set; } = new List<OrderItem>();

        public Order(MenuMenu menu)
        {
            Items = new List<OrderItem>();
            MenuList = menu.ReadMenuFile();
        }
        public List<OrderItem> CollectOrderInfo(int tableNo, int orderNo)
        {
            Console.WriteLine("Enter Menu item number:");
            int menuNo = MenuNoSelection();
            Console.WriteLine("Enter item quantity:");
            int menuNoQuantity = MenuNoSelection();
            double price = PriceCount(menuNo, menuNoQuantity);
            Items.Add(new OrderItem
                {
                    TableID = tableNo,
                    OrderID = orderNo,
                    OrderDate = DateTime.Now,
                    MenuNo = menuNo,
                    Quantity = menuNoQuantity,
                    Price = price,
                    IsPaid = false
                });
            return Items;
        }
        public int OrderSequence()
        {
            if (Items.Count == 0) return 1;
            else
            {
                int maxOrderID = Items.Max(id => id.OrderID);
                return maxOrderID + 1;
            }
        }
        public int MenuNoSelection()
        {
            int menuMin = 1;
            string menuInput = Console.ReadLine();
            bool menuCheck = int.TryParse(menuInput, out int menuOption);
            while (menuOption > 13 || menuOption < menuMin || !menuCheck)
            {
                Console.WriteLine("\nWrong input, numbers from 1 to 13 are only accepted.");
                Console.Write("Please re-enter menu choice:");
                string secondTry = Console.ReadLine();
                menuCheck = int.TryParse(secondTry, out menuOption);
            }
            return menuOption;
        }
        public double PriceCount(int menuNo, int quantity)
        {
            MenuItem item = MenuList.First(no => no.SequenceNo == menuNo);
            if (item != null)
            {
                return item.MealPrice * quantity;
            }
            else
            {
                throw new Exception("Menu item not found");
            }
        }
        public void OrderCheck(int tableNo)
        {
            var items = Items.Where(item => item.TableID == tableNo && item.IsPaid == false).ToList();
            double count = 0;
            if (items.Count > 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Cafe C# students" +
                    $"\n---------------------------------------" +
                    $"\nTable {tableNo}\n");

                foreach (OrderItem item in items)
                {
                    MenuItem menuItem = MenuList.First(no => no.SequenceNo == item.MenuNo);
                    Console.WriteLine($"{menuItem.MealName}".PadRight(25) + $"{menuItem.MealPrice}".PadLeft(5) + $"x {item.Quantity}".PadLeft(3)
                        + $"{item.Price} Eur".PadLeft(10));
                    item.IsPaid = true;
                    count += item.Price;
                }
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"\n{DateTime.Now}");
                Console.WriteLine("Total:" + count.ToString().PadLeft(34));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Table does not have any orders.");
            }
        }
        public void OrderSummary(int tableNo)
        {
            var items = Items.Where(item => item.TableID == tableNo && item.IsPaid == false).ToList();
            double count = 0;
            if (items.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Added Items:");
                foreach (OrderItem item in items)
                {
                    MenuItem menuItem = MenuList.First(no => no.SequenceNo == item.MenuNo);
                    Console.WriteLine($"{menuItem.MealName}".PadRight(25) + $"x {item.Quantity}".PadLeft(3)
                        + $"{item.Price} Eur".PadLeft(10));
                    count += item.Price;
                }
                Console.WriteLine("\nTotal:" + count.ToString().PadLeft(34));
            }
            else
            {
                Console.WriteLine("Table does not have any orders.");
            }
        }
    }
}
