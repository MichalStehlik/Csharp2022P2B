using System.Runtime.InteropServices;
using Cst17Testing;

namespace Cst17TestingTests
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator calc;

        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(2, calc.Addition(1,1));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(9, calc.Subtraction(10, 1));
            Assert.AreEqual(0, calc.Subtraction(0, 0));
            Assert.AreEqual(-100, calc.Subtraction(0, 100));
            Assert.AreEqual(-2, calc.Subtraction(2, 4));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(10, calc.Division(10, 1));
            Assert.AreEqual(5, calc.Division(10, 2));
            Assert.AreEqual(0, calc.Division(0, 1));
            Assert.AreEqual(-10, calc.Division(10, -1));
            Assert.AreEqual(3, calc.Division(-9, -3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivisionZero()
        {
            calc.Division(10,0);
        }
    }
}