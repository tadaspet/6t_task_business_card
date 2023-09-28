using _10.For_Cicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Tasks_V2
{
    [TestClass]
    public class ForCiclesTest
    {
        public class ForCicle11
        {
            [TestMethod]
            public void PrintOnlyEvenNumbersTEST()
            {
                int a = 40;
                int predicted = 21;
                int actual = ForCicles10.PrintOnlyEvenNumbers(a);
                Assert.AreEqual(predicted, actual);

            }
        }
        public class ForCicle12
        {
            [TestMethod]
            public void SumofUserInputNumberTEST()
            {
                int a = 4;
                int predicted = 10;
                int actual = ForCicles10.SumofUserInputNumber(a);
                Assert.AreEqual(predicted, actual);
            }
        }
        public class ForCIcle13
        {
            [TestMethod]

            public void SquareExponentByTheUserInputTEST()
            {
                double c = 7;
                double predicted = 49;
                double actual = ForCicles10.SquareExponentByTheUserInput(c);
                Assert.AreEqual(predicted, actual);
            }
        }
    }
}

