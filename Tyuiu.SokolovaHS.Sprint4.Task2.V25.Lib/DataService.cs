using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SokolovaHS.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEvenNumbers = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) // проверка на четность
                {
                    product *= array[i];
                    hasEvenNumbers = true;
                }
            }

            // Если четных чисел нет, возвращаем 0
            return hasEvenNumbers ? product : 0;
        }
    }
}