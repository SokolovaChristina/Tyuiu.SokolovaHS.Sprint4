using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SokolovaHS.Sprint4.Task7.V19.Lib
{
    public class DataService : ISprint4Task7V19
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int num = int.Parse(value[i * m + j].ToString());
                    if (num % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}