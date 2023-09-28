using _8.Unit_Testing_Tasks;

namespace _8.Testing_UNIT
{
    [TestClass]
    public class Kalkuliuok_TEST
    {
        [TestClass]
        public class Kalkuliuok_Test
        {
            [TestMethod]
            public void TestAdditionMath()
            {
                double no1 = 5;
                double no2 = 10;
                double expected = no1 + no2;

                double actual = Kalkuliuok.AdditionMath(no1, no2);

                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestSubtractionMath()
            {
                double no1 = 5;
                double no2 = 10;
                double expected = no1 - no2;

                double actual = Kalkuliuok.SubtractionMath(no1, no2);

                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMultiplicationMath()
            {
                double no1 = 5;
                double no2 = 10;
                double expected = no1 * no2;

                double actual = Kalkuliuok.MultiplicationMath(no1, no2);

                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestDivisionMath()
            {
                double no1 = 5;
                double no2 = 10;
                double expected = no1 / no2;

                double actual = Kalkuliuok.DivisionMath(no1, no2);

                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestRootMath()
            {
                double no1 = 9;
                double no2 = 2;
                double expected = 3;

                double actual = Kalkuliuok.RootMath(no1, no2);

                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestExponentionalMath()
            {
                double no1 = 3;
                double no2 = 2;
                double expected = no1 * no1;

                double actual = Kalkuliuok.ExponentionalMath(no1, no2);

                Assert.AreEqual(expected, actual);
            }

        }
    }
}