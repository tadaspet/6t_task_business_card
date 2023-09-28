using _8.Unit_Testing_Tasks;

namespace _8.Testing_UNIT
{
 
        [TestClass]

        public class Conditionals_IF_1
        {
        [TestMethod]
            public void TestNumberIsDividingByOnly2()
            {
                int no1 = 6;
                string expected = "Number is dividing by 2";

                string actual = Conditionals_IF.NumberIsDividingBy2or5(no1);

                Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void TestNumberIsDividingByOnly5()
            {
                int no1 = 15;
                string expected = "Number is divinding by 5";

                string actual = Conditionals_IF.NumberIsDividingBy2or5(no1);

                Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void TestNumberIsDividingByFalse()
            {
                int no1 = 7;
                string expected = "Number is not dividing by 2 or 5";

                string actual = Conditionals_IF.NumberIsDividingBy2or5(no1);

                Assert.AreEqual(expected, actual);
            }

        }
        [TestClass]
        public class Conditionals_IF_2
        {
        [TestMethod]
        public void Test_TemperatureAnswer_VeryCold()
            {
                int no1 = -10;
                string expected = "Temperature is VERY COLD";

                string actual = Conditionals_IF.TemperatureAnswer(no1);

                Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void Test_TemperatureAnswer_Chill()
            {
                int no1 = 15;
                string expected = "Temperature is CHILL";

                string actual = Conditionals_IF.TemperatureAnswer(no1);

                Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void Test_TemperatureAnswer_Hot()
            {
                int no1 = 35;
                string expected = "Temperature is HOT";

                string actual = Conditionals_IF.TemperatureAnswer(no1);

                Assert.AreEqual(expected, actual);
            }
        }
        [TestClass]
        public class Conditionals_IF_3
        {
        [TestMethod]
        public void Test_CheckNumbersAreEqual_AllEqual()
            {
                int no1 = 5;
                int no2 = 5;
                int no3 = 5;

                string expected = "Visi skaiciai lygus";
                string actual = Conditionals_IF.CheckNumbersAreEqual(no1, no2, no3);
                Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void Test_CheckNumbersAreEqual_TwoEqual()
            {
                int no1 = 3;
                int no2 = 4;
                int no3 = 3;

                string expected = "Du skaiciai lygus";
                string actual = Conditionals_IF.CheckNumbersAreEqual(no1, no2, no3);
                Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void Test_CheckNumbersAreEqual_NotEqual()
            {
                int no1 = 1;
                int no2 = 4;
                int no3 = 18;

                string expected = "Ne vienas skaicius nera lygus";
                string actual = Conditionals_IF.CheckNumbersAreEqual(no1, no2, no3);
                Assert.AreEqual(expected, actual);
            }
        }
}
