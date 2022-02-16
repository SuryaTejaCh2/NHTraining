using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatheMatics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheMatics.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        Algebra a = new Algebra();
        [TestMethod()]
        public void FactorialTestInputZero()
        {
            //Arrange
            int n = 0, actual, expected = 1;
            //Act
            actual = a.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTestInputOnetoSeven()
        {
            //Arrange
            int n = 5, actual, expected = 120;
            //Act
            actual = a.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTestInputNegativeNumbers()
        {
            //Arrange
            int n = -7, actual, expected = -9999;
            //Act
            actual = a.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTestInputGreaterThanSeven()
        {
            //Arrange
            int n = 9, actual, expected = -999;
            //Act
            actual = a.Factorial(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTestInputPalindrome()
        {
            //Arrange
            int input = 12321, actual, expected = 12321;
            //Act
            actual = a.Palindrome(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}