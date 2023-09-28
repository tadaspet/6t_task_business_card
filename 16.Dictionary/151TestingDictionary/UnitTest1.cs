using _16.Dictionary;

namespace _151TestingDictionary
{
    [TestClass]
    public class UnitTestDictionary12
    {
        [TestMethod]
        public void CountryCapitalsTestMethod1()
        {
            string input = "Lietuva";
            string expected = "Vilnius";
            string actual = DictionaryTasks.CountryCapitals(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CountryCapitalsTestMethod2()
        {
            string input = "Estija";
            string expected = "Talinas";
            string actual = DictionaryTasks.CountryCapitals(input);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class UnitTestDictionary13
    {
        [TestMethod]
        public void FruitQuantityListTestMethod1()
        {
            Dictionary<string, int> inputDict = new Dictionary<string, int>()
            {
                {"Apples", 3 },
                {"Pears", 5 },
                {"Bananas", 2 },
                {"Lemon", 4 }
            };
            string fruitName = "Bananas";
            int quantity = 0;

            inputDict = DictionaryTasks.FruitQuantityList(inputDict, fruitName, quantity);

            Assert.AreEqual(quantity, inputDict[fruitName]);
        }
        [TestMethod]
        public void FruitQuantityListTestMethod2()
        {
            Dictionary<string, int> inputDict = new Dictionary<string, int>()
            {
                {"Apples", 3 },
                {"Pears", 5 },
                {"Bananas", 2 },
                {"Lemon", 4 }
            };
            string fruitName = "Orange";
            int quantity = 7;

            inputDict = DictionaryTasks.FruitQuantityList(inputDict, fruitName, quantity);

            Assert.IsTrue(inputDict.ContainsKey(fruitName));
            Assert.AreEqual(quantity, inputDict[fruitName]);
        }
    }
}
