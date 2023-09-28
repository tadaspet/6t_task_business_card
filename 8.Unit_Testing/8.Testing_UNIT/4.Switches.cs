using _8.Unit_Testing_Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Testing_UNIT
{
    [TestClass]
    public class Switches_1
    {
        [TestMethod]
        public void Test_DayNumber1()
        {
            string no1 = "1";
            string expected = "Monday";
            string actual = SwitchCases.DayAnswer(no1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_DayNumber7()
        {
            string no1 = "7";
            string expected = "Sunday";
            string actual = SwitchCases.DayAnswer(no1);
            Assert.AreEqual(expected, actual);
        }
        [TestClass]
        public class Switches_2
        {
            [TestMethod]
            public void Test1_MonthAnswer()
            {
                string monthNo = "2001-1";
                string expected = "Sausis";
                string actual = SwitchCases.MonthAnswer(monthNo);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Test2_MonthAnswer()
            {
                string monthNo = "9999-9";
                string expected = "Rugsejis";
                string actual = SwitchCases.MonthAnswer(monthNo);
                Assert.AreEqual(expected, actual);
            }

        }
    }
}
