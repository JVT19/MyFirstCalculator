using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        [DataRow(15, 28, 43)]
        [DataRow(-23, 3, -20)]
        [DataRow(-5, 18, 13)]
        [DataRow(6, -8, -2)]
        [DataRow(26, -7, 19)]
        [DataRow(-7, -9, -16)]
        public void SumTest(int x, int y, int expected)
        {
            var actual = calculator.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(32, 25, 7)]
        [DataRow(15, 24, -9)]
        [DataRow(-4, -6, 2)]
        [DataRow(-8, -6, -2)]
        [DataRow(10, -4, 14)]
        [DataRow(-7, 5, -12)]
        public void SubstractTest(int x, int y, int expected)
        {
            var actual = calculator.Substract(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(32, 0, 0)]
        [DataRow(3, 7, 21)]
        [DataRow(-4, 5, -20)]
        [DataRow(6, -8, -48)]
        [DataRow(-5, -5, 25)]
        [DataRow(8, 1, 8)]
        public void MultiplyTest(int x, int y, int expected)
        {
            var actual = calculator.Multiply(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(33, 3, 11)]
        [DataRow(12, 6, 2)]
        public void DivideTest(int x, int y, int expected)
        {
            var actual = calculator.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}