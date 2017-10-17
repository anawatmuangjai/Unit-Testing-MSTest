using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Plus_PositiveNumber_ReturnPositiveValue()
        {
            // Arrange
            int expected = 80;
            int firstnumber = 35;
            int secondnumber = 45;

            // Act
            int actual = Calculator.PlusTwoNumber(firstnumber, secondnumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Minus_PositiveNumber_ReturnPositiveValue()
        {
            // Arrange
            int expected = 35;
            int firstnumber = 70;
            int secondnumber = 35;

            // Act
            int actual = Calculator.MinusTwoNumber(firstnumber, secondnumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_PositiveNumber_ReturnPositiveValue()
        {
            // Arrange
            int expected = 180;
            int firstnumber = 30;
            int secondnumber = 6;

            // Act
            int actual = Calculator.MultiplyTwoNumber(firstnumber, secondnumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Devide_PositiveNumber_ReturnPositiveValue()
        {
            // Arrange
            int expected = 5;
            int firstnumber = 30;
            int secondnumber = 6;

            // Act
            int actual = Calculator.DevideTwoNumber(firstnumber, secondnumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
