using _9._Ref_and_out;
using System.Xml.Linq;

namespace Testing_Tasks_V2
{
    [TestClass]
    public class Ref_Out_Task11
    {
        [TestMethod]
        public void RefSwapValueTest1()
        {
            int x11 = 1;
            int expected = 23;

            int actual = RefAndOutTasks.Swap(ref x11);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int x11 = 50;
            int expected = 23;

            int actual = RefAndOutTasks.Swap(ref x11);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Ref_Out_Task12
    {
        [TestMethod]
        public void IncrementByN_Test1()
        {
            int a = 13;
            int expected = a * 2;
            int actual = RefAndOutTasks.IncrementByN(ref a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IncrementByN_Test2()
        {
            int a = 10;
            int expected = a * 2;
            int actual = RefAndOutTasks.IncrementByN(ref a);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Ref_Out_Task13
    {
        [TestMethod]
        public void TrimAndCapitalize_Test1()
        {
            string text = "    labas vakaras   ";
            string expected = "Labas vakaras";
            string actual = RefAndOutTasks.TrimAndCapitalize(ref text);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TrimAndCapitalize_Test2()
        {
            string text = " 11 testas   ";
            string expected = "11 testas";
            string actual = RefAndOutTasks.TrimAndCapitalize(ref text);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Ref_Out_Task21
    {
        [TestMethod]
        public void GetUserData_Test1()
        {
            string test1 = "Patikra";
            string test2 = "Labas vakaras";
            string expected = test1;
            string actual = RefAndOutTasks.GetUserData(out test1, out test2);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void GetUserData_Test2()
        {
            string name = "Betkas";
            string surName = "kazkas";
            string expected = "Vardas";
            string actual = RefAndOutTasks.GetUserData(out name, out surName);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Ref_Out_Task22
    {
        [TestMethod]
        public void WhileCicle22_Test1()
        {
            double test2 = 1;
            string textInPut = "91";
            bool logic = true;
            double number = 101;
            double actual = RefAndOutTasks.WhileCicle22(out test2, out textInPut, out logic);
            Assert.AreNotEqual(number, logic);
        }
        [TestMethod]
        public void WhileCicle22_Test2()
        {
            double test2 = 1;
            string textInPut = "99";
            bool logic;
            double expected = 109;
            double actual = RefAndOutTasks.WhileCicle22(out test2, out textInPut, out logic);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Ref_Out_Task23
    {
        [TestMethod]
        public void Divide33_Test1()
        {
            string text1 = "8";
            string text2 = "7";
            double no1 = 8;
            double no2 = 7;
            bool check = true;
            double expected = 1;
            double actual = RefAndOutTasks.Divide23(out text1, out text2, out no1,out no2,out check);
            Assert.AreEqual(expected, actual);
        }
    }

}