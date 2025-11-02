using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SokolovaHS.Sprint4.Task5.V23.Lib
{
    public class DataService : ISprint4Task5V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0) // проверка на отрицательность
                    {
                        matrix[i, j] = 0; // замена отрицательных элементов на 0
                    }
                }
            }

            return matrix;
        }
    }
}
