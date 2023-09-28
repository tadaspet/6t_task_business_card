using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Testing_UNIT
{
    public class Char_Array
    {
        [TestClass]
        public class Char_Array_Test1
        {
            [TestMethod]
            public void Test1_GuessWordReversedAnswer()
            {
                string word1 = "labas";
                string expected = "sabal";
                string actual = CharArray.ReversedWord(word1);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Test2_GuessWordReversedAnswer()
            {
                string word1 = "testas";
                string expected = "Neapsuktas zodis.";
                string actual = CharArray.ReversedWord(word1);
                Assert.AreEqual(expected, actual);
            }
        }
        [TestClass]
        public class Char_Array_Test2
        {
            [TestMethod]
            public void Test1_WordContainsALetter()
            {
                string word1 = "Kada?";
                string expected = "Jusu ivestame zodyje yra raide 'a'.";
                string actual = CharArray.WordContainsALetter(word1);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Test2_WordContainsALetter()
            {
                string word1 = "Nezino...";
                string expected = "Zodyje 'a' simbolis nerastas.";
                string actual = CharArray.WordContainsALetter(word1);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
