using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SokolovaHS.Sprint4.Task4.V4.Lib
{
    public class DataService : ISprint4Task4V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0) // проверка на четность
                    {
                        matrix[i, j] = 1; // замена четных элементов на 1
                    }
                }
            }

            return matrix;
        }
    }
}
