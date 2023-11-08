namespace II._19.Advanced.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem menuItem = new MenuItem();
            MenuMenu foodMenu = new MenuMenu();

            var table = new TableMenu();
            table.CreateTables();

            Order newOrder = new Order(foodMenu);
            UINavigation actionMenu = new UINavigation();

            int menuOption = 0;
            const int mainMenuMax = 4;
            const int subMenuMax = 3;
            do
            {
                actionMenu.PrintMainInterface();
                menuOption = actionMenu.ActionMainMenu(mainMenuMax);
                switch(menuOption)
                {
                    case 1:
                        {
                            foodMenu.PrintMenu();
                            actionMenu.Return();
                        }
                        break;
                    case 2:
                        {
                            table.PrintTableList();
                            actionMenu.Return();
                        }
                        break;
                    case 3:
                        {
                            int tableNo = table.SelectTable();
                            actionMenu.PrintSubInterface(tableNo);
                            int subOption = actionMenu.ActionMainMenu(subMenuMax);
                            switch (subOption)
                            {
                                case 1:
                                    {
                                        table.SetTableTaken(tableNo);
                                        do
                                        {
                                            int orderNo = newOrder.OrderSequence();
                                            newOrder.CollectOrderInfo(tableNo, orderNo);
                                            newOrder.OrderSummary(tableNo);
                                        } while (actionMenu.MenuChoice() == UINavigation.UserChoice.Continue);
                                    }
                                    break;
                                case 2:
                                    {
                                        newOrder.OrderCheck(tableNo);
                                        table.SetTableEmpty(tableNo);
                                        actionMenu.Return();
                                    }
                                    break;
                                case 3:
                                    {
                                        menuOption = 1;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 4:
                        {
                            actionMenu.Quit();
                        }
                        break;
                }
            } while(menuOption > 0 && menuOption <= mainMenuMax);
        }
    }
}