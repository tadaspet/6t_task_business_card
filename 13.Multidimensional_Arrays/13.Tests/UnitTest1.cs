using _13.Multidimensional_Arrays;

namespace _13.Tests
{
    [TestClass]
    public class Task11
    {
        [TestMethod]
        public void AverageArrayTest1()
        {
            double[] a = { 3, 4, 2 };
            double expected = 3;

            double actual = MultidimensionalArray.AverageArray(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AverageArrayTest2()
        {
            double[] a = { 3, 4, 2, 7 };
            double expected = 4;

            double actual = MultidimensionalArray.AverageArray(a);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Task12
    {
        [TestMethod]
        public void PosstiveNumberArray()
        {
            double[] a = { 1, 2, -3, -5, 6, 7 };
            double[] expected = { 1, 2, 6, 7, 0, 0 };
            double[] actual = MultidimensionalArray.ReturnPossitiveNumberArrary(a);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void PosstiveNumberArray2()
        {
            double[] a = { 1, 2, 6, 7 };
            double[] expected = { 1, 2, 6, 7 };
            double[] actual = MultidimensionalArray.ReturnPossitiveNumberArrary(a);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
    [TestClass]

    public class Task13
    {
        [TestMethod]
        public void CountGPM()
        {
            double[] num = { 100, 200, 100, 300, 500, };
            double[] expected = { 75, 150, 75, 225, 375 };
            double[] actual = MultidimensionalArray.ReturnTaxes(num);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void CountGPM2()
        {
            double[] num = { 100, 200 };
            double[] expected = { 75, 150 };
            double[] actual = MultidimensionalArray.ReturnTaxes(num);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
    [TestClass]

    public class Task14
    {
        [TestMethod]
        public void WordLengthInSentence()
        {
            string word = "Koks pasaulis yra grazus ir nuostabus";
            string[] expected = { "pasaulis", "grazus", "nuostabus", null, null, null };
            string[] actual = MultidimensionalArray.SentenceReturn(word);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void WordLengthInSentence2()
        {
            string word = "Koks kitoks nebetkoks anoks";
            string[] expected = { "kitoks", "nebetkoks", "anoks", null};
            string[] actual = MultidimensionalArray.SentenceReturn(word);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
    [TestClass]

    public class Task21
    {
        [TestMethod]
        public void CardDeck1()
        {
            string[] cardType = { "Pikai","Bugnai" };
            string[] cardNo = { "1", "2" };
            string[] expected = { "1.Pikai","2.Pikai","1.Bugnai","2.Bugnai" };
            string[] actual = MultidimensionalArray.CardDeck(cardType,cardNo);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void CardDeck2()
        {
            string[] cardType = { "Bugnai" };
            string[] cardNo = { "1", "2" };
            string[] expected = { "1.Bugnai", "2.Bugnai" };
            string[] actual = MultidimensionalArray.CardDeck(cardType, cardNo);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}