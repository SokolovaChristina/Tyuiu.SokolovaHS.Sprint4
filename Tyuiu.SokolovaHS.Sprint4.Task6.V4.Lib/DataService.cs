using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SokolovaHS.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            string[] result = array.Where(city => city.Length < 7).ToArray();
            return result;
        }
    }
}
