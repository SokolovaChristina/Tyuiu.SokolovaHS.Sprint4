using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint4.Task7.V19.Lib;
namespace Tyuiu.SokolovaHS.Sprint4.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string value = "90817264";

            int res = ds.Calculate(n, m, value);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}