using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint4.Task3.V15.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = {
                {7, 4, 2, 5, 3},
                {4, 3, 2, 5, 6},
                {6, 3, 4, 7, 5},
                {5, 7, 4, 3, 8},
                {7, 8, 8, 5, 6}
            };
            int wait = 11; // нечетные: 7,5,3,3,5,7,5,7,3,7,5

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithAllOddNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                {3, 5, 7, 9, 3},
                {5, 7, 9, 3, 5},
                {7, 9, 3, 5, 7},
                {9, 3, 5, 7, 9},
                {3, 5, 7, 9, 3}
            };
            int wait = 25; // все элементы нечетные

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithAllEvenNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                {2, 4, 6, 8, 2},
                {4, 6, 8, 2, 4},
                {6, 8, 2, 4, 6},
                {8, 2, 4, 6, 8},
                {2, 4, 6, 8, 2}
            };
            int wait = 0; // все элементы четные

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithMixedNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };
            int wait = 13; // нечетные: 1,3,5,7,9,11,13,15,17,19,21,23,25

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSingleElementOdd()
        {
            DataService ds = new DataService();

            int[,] array = { { 3 } };
            int wait = 1;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSingleElementEven()
        {
            DataService ds = new DataService();

            int[,] array = { { 4 } };
            int wait = 0;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithEmptyArray()
        {
            DataService ds = new DataService();

            int[,] array = new int[0, 0];
            int wait = 0;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}