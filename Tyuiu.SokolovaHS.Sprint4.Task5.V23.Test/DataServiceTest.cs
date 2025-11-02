using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint4.Task5.V23.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = {
                { -3, 5, -1, 8, 0 },
                { 4, -2, 7, -4, 6 },
                { -1, 3, 8, -3, 5 },
                { 2, -4, 6, 7, -2 },
                { 8, 0, -1, 4, 5 }
            };

            int[,] wait = {
                { 0, 5, 0, 8, 0 },
                { 4, 0, 7, 0, 6 },
                { 0, 3, 8, 0, 5 },
                { 2, 0, 6, 7, 0 },
                { 8, 0, 0, 4, 5 }
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithAllNegativeNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                { -4, -3, -2, -1, -4 },
                { -3, -2, -1, -4, -3 },
                { -2, -1, -4, -3, -2 },
                { -1, -4, -3, -2, -1 },
                { -4, -3, -2, -1, -4 }
            };

            int[,] wait = {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithAllPositiveNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 1, 2 },
                { 3, 4, 5, 6, 7 },
                { 8, 1, 2, 3, 4 },
                { 5, 6, 7, 8, 1 }
            };

            int[,] wait = {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 1, 2 },
                { 3, 4, 5, 6, 7 },
                { 8, 1, 2, 3, 4 },
                { 5, 6, 7, 8, 1 }
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithMixedNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                { -4, 8, -3, 7, -2 },
                { 5, -1, 6, -4, 8 },
                { -2, 7, -1, 5, -3 },
                { 6, -4, 8, -2, 7 },
                { -1, 5, -3, 8, -4 }
            };

            int[,] wait = {
                { 0, 8, 0, 7, 0 },
                { 5, 0, 6, 0, 8 },
                { 0, 7, 0, 5, 0 },
                { 6, 0, 8, 0, 7 },
                { 0, 5, 0, 8, 0 }
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSingleNegativeElement()
        {
            DataService ds = new DataService();

            int[,] array = { { -3 } };
            int[,] wait = { { 0 } };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSinglePositiveElement()
        {
            DataService ds = new DataService();

            int[,] array = { { 5 } };
            int[,] wait = { { 5 } };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithZeroElements()
        {
            DataService ds = new DataService();

            int[,] array = {
                { 0, -1, 2 },
                { -2, 0, 1 },
                { 1, -2, 0 }
            };

            int[,] wait = {
                { 0, 0, 2 },
                { 0, 0, 1 },
                { 1, 0, 0 }
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}