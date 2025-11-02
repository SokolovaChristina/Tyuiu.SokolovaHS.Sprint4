using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint4.Task0.V14.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int wait = 30; // 9 + 5 + 3 + 1 + 5 + 7 = 30

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetSumOddArrEl_WithAllEvenNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 8, 10 };
            int wait = 0;

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetSumOddArrEl_WithAllOddNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 1, 3, 5, 7, 9 };
            int wait = 25; // 1 + 3 + 5 + 7 + 9 = 25

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetSumOddArrEl_WithEmptyArray()
        {
            DataService ds = new DataService();

            int[] array = new int[0];
            int wait = 0;

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetSumOddArrEl_WithSingleOddElement()
        {
            DataService ds = new DataService();

            int[] array = { 7 };
            int wait = 7;

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetSumOddArrEl_WithSingleEvenElement()
        {
            DataService ds = new DataService();

            int[] array = { 4 };
            int wait = 0;

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetSumOddArrEl_WithNegativeOddNumbers()
        {
            DataService ds = new DataService();

            int[] array = { -1, -3, 2, 4, -5 };
            int wait = -9; // -1 + (-3) + (-5) = -9

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}