using II._19.Advanced.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamUnitTests
{
    [TestClass]
    public class OrderMenuTest
    {
        [TestMethod]
        public void PriceCountTest()
        {
            // Arrange
            var menu = new MenuMenu();
            var newOrder = new Order(menu);
            int menuNo1 = 3;
            int menuNo2 = 5;
            int quantity = 2;
            double expected1 = 10; //price 5.00 times 2 = 10
            double expected2 = 30; //price 15.00 times 2 = 30

            // Act
            double actual1 = newOrder.PriceCount(menuNo1,quantity);
            double actual2 = newOrder.PriceCount(menuNo2, quantity);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void OrderSequenceTest1()
        {
            // Arrange
            var menu = new MenuMenu();
            var newOrder = new Order(menu);
            newOrder.Items.Add(new OrderItem { OrderID = 5 });

            // Act
            int actual = newOrder.OrderSequence();

            // Assert
            Assert.AreEqual(6, actual);
        }
        [TestMethod]
        public void OrderSequenceTest2()
        {
            // Arrange
            var menu = new MenuMenu();
            var newOrder = new Order(menu);
            newOrder.Items.Add(new OrderItem { OrderID = 1 });

            // Act
            int actual = newOrder.OrderSequence();

            // Assert
            Assert.AreNotEqual(6, actual);
        }
    }
}
