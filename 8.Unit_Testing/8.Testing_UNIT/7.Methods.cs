using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Testing_UNIT
{
    [TestClass]
    public class Method1
    {
        [TestMethod]
        public void IsNumberEvenCheck()
        {
        int no1 = 7;
        bool expected = false;
        bool actual = MethodTasks.IsNumberEven(no1);
        Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsNumberOddCheck()
        {
        int no2 = 6;
        bool expected = true;
        bool actual = MethodTasks.IsNumberEven(no2);
        Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Method2
    {
        [TestMethod]
        public void FibonacciNextNumberAfter100() 
        {
            int Fib1 = 0;
            int Fib2 = 1;
            int expected = 89;
            int actual = MethodTasks.Fibonacci(Fib1, Fib2);
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class Method3
    {
        [TestMethod]
        public void FaktorialofNumberResult1()
        {
            int no1 = 1;
            int expected = 1;
            int actual = MethodTasks.FactorialNumber(no1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FaktorialofNumberResult2()
        {
            int no1 = 3;
            int expected = 6;
            int actual = MethodTasks.FactorialNumber(no1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FaktorialofNumberResult5()
        {
            int no1 = 5;
            int expected = 120;
            int actual = MethodTasks.FactorialNumber(no1);
            Assert.AreEqual(expected, actual);
        }
    }
}
