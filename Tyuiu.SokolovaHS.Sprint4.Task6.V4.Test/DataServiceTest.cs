using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint4.Task6.V4.Lib;
namespace Tyuiu.SokolovaHS.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] cities = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };

            string[] res = ds.Calculate(cities);
            string[] wait = { "Москва", "Самара" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
