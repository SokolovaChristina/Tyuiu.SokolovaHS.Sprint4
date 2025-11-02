using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SokolovaHS.Sprint4.Task1.V7.Lib
{
    public class DataService : ISprint4Task1V7
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) // проверка на четность
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}