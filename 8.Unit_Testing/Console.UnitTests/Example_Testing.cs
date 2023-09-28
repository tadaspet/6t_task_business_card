using _8.Unit_Testing;
using _8.Unit_Testing_Tasks;
using static _8.Unit_Testing_Tasks.Program;

namespace Console.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void GetTextLength_LeadWhiteSpacedText_ReturnsLength()
        {
            // Arrange
            string text = " Hello ";
            int expected = 5;

            // Act
            int actual = Calculator.GetTextLength(text, false);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTextLength_WithoutLeadWhiteSpacedText_ReturnsLength()
        {
            // Arrange
            string text = " Laba diena ";
            int expected = 10;

            // Act
            int actual = Calculator.GetTextLength(text, true);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_AdditionMath()
        {
            double no1 = 8;
            double no2 = 8;
            double expected = 64;

            double actual = Kalkuliuok.AdditionMath(no1, no2);

            Assert.AreEqual(expected, actual);
        }
    }
}