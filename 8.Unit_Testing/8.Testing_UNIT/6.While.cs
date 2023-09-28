using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Testing_UNIT
{
    public class While_Test
    {
        [TestClass]
        public class While_1
        {
            [TestMethod]
            public void Test1_NumberExponent()
            {
                double no1 = 2;
                double no2 = 4;
                double expected = 16;
                double actual = While.NumberExponent(no1, no2);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Test2_WhileExponentCheck()
            {
                double no1 = 2;
                double no2 = 4;
                bool expected = true;
                bool actual = While.NumberExponentCheck1(no1, no2);
                Assert.AreEqual(expected, actual);
            }
        }
        [TestClass]
        public class While_2
        {
            [TestMethod]
            public void Test1_PositiveNumberCheck()
            {
                int no1 = 0;
                bool expected = false;
                bool actual = While.PositiveNumberCheck(no1);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Test2_RowCount()
            {
                int no1 = 18;
                double expected = no1 + 1;
                double actual = While.RowCount(no1);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
