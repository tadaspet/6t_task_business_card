using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._19.Advanced.Exam
{
    internal class TableMenu
    {
        public List<TableItem> TableList { get; set; }
        const int tableCount = 10;
        public List<TableItem> CreateTables()
        {
            var tableList = new List<TableItem>();

            for (int i = 1; i <= tableCount; i++)
            {
                tableList.Add(
                    new TableItem
                    {
                        TableNo = i,
                        Status = true
                    });
            }
            TableList = tableList;
            return tableList;
        }
        public void PrintTableList()
        {
            Console.WriteLine("Table List\n" +
                $"{ "No.".PadLeft(3)} {"Status".PadLeft(7)}");
            foreach (TableItem table in TableList)
            {
                string status = table.Status ? "Empty" : "Taken";
                Console.WriteLine(table.TableNo.ToString().PadLeft(2) + status.ToString().PadLeft(8));
            }
        }
        public int SelectTable()
        {
            PrintTableList();
            Console.WriteLine("\nEnter Table No to work with:");
            int menuMin = 1;
            string menuInput = Console.ReadLine();
            bool menuCheck = int.TryParse(menuInput, out int menuOption);
            while (menuOption > tableCount || menuOption < menuMin || !menuCheck)
            {
                Console.WriteLine("\nWrong input, numbers from 1 to 10 are only accepted.");
                Console.Write("Please re-enter Table No.:");
                string secondTry = Console.ReadLine();
                menuCheck = int.TryParse(secondTry, out menuOption);
            }
            Console.Clear();
            return menuOption;
        }
        public void SetTableTaken(int tableNo)
        {
            TableItem selectedTable = TableList.FirstOrDefault(no => no.TableNo == tableNo);
            if (selectedTable != null)
            {
                selectedTable.Status = false;
            }
        }
        public void SetTableEmpty(int tableNo)
        {
            TableItem selectedTable = TableList.FirstOrDefault(no => no.TableNo == tableNo);
            if (selectedTable != null)
            {
                selectedTable.Status = true;
            }
        }
    }
}
