using Tyuiu.SokolovaHS.Sprint4.Task1.V7.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.SokolovaHS.Sprint4.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Calculate_WithValidArray_ReturnsCorrectSum()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            int expected = 24; // 2 + 8 + 2 + 6 + 2 + 4 = 24

            // Act
            int actual = ds.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithAllOddNumbers_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 3, 5, 7, 5, 3 };
            int expected = 0;

            // Act
            int actual = ds.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithAllEvenNumbers_ReturnsSum()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 8, 2, 4 };
            int expected = 26; // 2 + 4 + 6 + 8 + 2 + 4 = 26

            // Act
            int actual = ds.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithEmptyArray_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = new int[0];
            int expected = 0;

            // Act
            int actual = ds.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithSingleEvenElement()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 4 };
            int expected = 4;

            // Act
            int actual = ds.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithSingleOddElement()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 3 };
            int expected = 0;

            // Act
            int actual = ds.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_WithMixedNumbersInRange()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int expected = 20; // 2 + 4 + 6 + 8 = 20

            // Act
            int actual = ds.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}