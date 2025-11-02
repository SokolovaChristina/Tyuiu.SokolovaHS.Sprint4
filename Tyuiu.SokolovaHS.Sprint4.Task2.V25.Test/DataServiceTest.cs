using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint4.Task2.V25.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 6, 7, 8, 3, 4, 9, 6, 5, 8 };
            int wait = 4 * 6 * 8 * 4 * 6 * 8; // 36864

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithAllOddNumbers_ReturnsZero()
        {
            DataService ds = new DataService();

            int[] array = { 3, 5, 7, 9, 3, 5, 7, 9, 5, 3, 7 };
            int wait = 0;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithAllEvenNumbers_ReturnsProduct()
        {
            DataService ds = new DataService();

            int[] array = { 4, 6, 8, 4, 6, 8, 4, 6, 8, 4, 6 };
            int wait = 4 * 6 * 8 * 4 * 6 * 8 * 4 * 6 * 8 * 4 * 6;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSingleEvenElement()
        {
            DataService ds = new DataService();

            int[] array = { 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            int wait = 4;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSingleOddElement()
        {
            DataService ds = new DataService();

            int[] array = { 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            int wait = 4 * 4 * 4 * 4 * 4 * 4 * 4 * 4 * 4 * 4;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithMixedNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 4, 3, 6, 5, 8, 7, 4, 9, 6, 5, 8 };
            int wait = 4 * 6 * 8 * 4 * 6 * 8; // 36864

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithNoEvenNumbers_ReturnsZero()
        {
            DataService ds = new DataService();

            int[] array = { 3, 5, 7, 9, 3, 5, 7, 9, 3, 5, 7 };
            int wait = 0;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}