using System;
using Tyuiu.SokolovaHS.Sprint4.Task5.V23.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 8.               *");
            Console.WriteLine("* Заменить отрицательные элементы на 0.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Создание и заполнение массива случайными числами
            Random random = new Random();
            int[,] array = new int[5, 5];

            Console.WriteLine("Массив 5x5 (диапазон -4 до 8):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-4, 9); // от -4 до 8 включительно
                }
            }

            // Вывод исходного массива
            PrintArray(array, "Исходный массив:");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Замена отрицательных элементов на 0 с использованием библиотеки
            DataService ds = new DataService();
            int[,] resultArray = ds.Calculate((int[,])array.Clone());

            PrintArray(resultArray, "Массив после замены отрицательных элементов на 0:");

            Console.ReadKey();
        }

        static void PrintArray(int[,] array, string title)
        {
            Console.WriteLine(title);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                Console.Write("    ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j],3} "); // форматирование для выравнивания
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintChangesStatistics(int[,] original, int[,] modified)
        {
            int rows = original.GetLength(0);
            int columns = original.GetLength(1);
            int changedCount = 0;
            int unchangedCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (original[i, j] < 0)
                    {
                        negativeCount++;
                    }

                    if (original[i, j] != modified[i, j])
                    {
                        changedCount++;
                    }
                    else
                    {
                        unchangedCount++;
                    }
                }
            }

            Console.WriteLine($"Статистика изменений:");
            Console.WriteLine($"Отрицательных элементов в исходном массиве: {negativeCount}");
            Console.WriteLine($"Изменено элементов: {changedCount}");
            Console.WriteLine($"Неизмененных элементов: {unchangedCount}");
            Console.WriteLine($"Всего элементов: {original.Length}");
        }
    }
}