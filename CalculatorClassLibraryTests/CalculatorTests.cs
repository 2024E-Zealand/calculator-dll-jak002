using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int result = Calculator.Add(10, 10);
            Assert.AreEqual(20, result);
        }
        [TestMethod()]
        public void SubtractTest()
        {
            int result = Calculator.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            int result = Calculator.Multiply(10,2); 
            Assert.AreEqual(20, result);
        }
    }
}