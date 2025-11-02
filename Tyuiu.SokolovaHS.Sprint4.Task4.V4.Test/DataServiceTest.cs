using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint4.Task4.V4.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = {
                {5, 9, 6, 8, 5},
                {6, 6, 7, 3, 8},
                {4, 3, 9, 8, 7},
                {3, 3, 6, 7, 7},
                {8, 3, 8, 6, 6}
            };

            int[,] wait = {
                {5, 9, 1, 1, 5},
                {1, 1, 7, 3, 1},
                {1, 3, 9, 1, 7},
                {3, 3, 1, 7, 7},
                {1, 3, 1, 1, 1}
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithAllEvenNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                {4, 6, 8, 4, 6},
                {6, 8, 4, 6, 8},
                {4, 6, 8, 4, 6},
                {6, 8, 4, 6, 8},
                {4, 6, 8, 4, 6}
            };

            int[,] wait = {
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1}
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
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

            int[,] wait = {
                {3, 5, 7, 9, 3},
                {5, 7, 9, 3, 5},
                {7, 9, 3, 5, 7},
                {9, 3, 5, 7, 9},
                {3, 5, 7, 9, 3}
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithMixedNumbers()
        {
            DataService ds = new DataService();

            int[,] array = {
                {3, 4, 5, 6, 7},
                {8, 9, 2, 3, 4},
                {5, 6, 7, 8, 9},
                {2, 3, 4, 5, 6},
                {7, 8, 9, 2, 3}
            };

            int[,] wait = {
                {3, 1, 5, 1, 7},
                {1, 9, 1, 3, 1},
                {5, 1, 7, 1, 9},
                {1, 3, 1, 5, 1},
                {7, 1, 9, 1, 3}
            };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSingleElementEven()
        {
            DataService ds = new DataService();

            int[,] array = { { 4 } };
            int[,] wait = { { 1 } };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Calculate_WithSingleElementOdd()
        {
            DataService ds = new DataService();

            int[,] array = { { 5 } };
            int[,] wait = { { 5 } };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}