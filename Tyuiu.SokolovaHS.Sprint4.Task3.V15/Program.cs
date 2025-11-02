using System;
using Tyuiu.SokolovaHS.Sprint4.Task3.V15.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 9.              *");
            Console.WriteLine("* Подсчитайте количество нечетных элементов во всем массиве.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Статический массив 5x5 из задания
            int[,] array = new int[5, 5] {
                {7, 4, 2, 5, 3},
                {4, 3, 2, 5, 6},
                {6, 3, 4, 7, 5},
                {5, 7, 4, 3, 8},
                {7, 8, 8, 5, 6}
            };

            Console.WriteLine("Массив 5x5:");
            PrintArray(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Подсчет количества нечетных элементов с использованием библиотеки
            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"Количество нечетных элементов в массиве: {result}");

            Console.ReadKey();
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                Console.Write("    ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static string GetOddElementsString(int[,] array)
        {
            System.Collections.Generic.List<int> oddElements = new System.Collections.Generic.List<int>();
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        oddElements.Add(array[i, j]);
                    }
                }
            }

            return oddElements.Count > 0 ? "{ " + string.Join(", ", oddElements) + " }" : "нечетных элементов нет";
        }
    }
}