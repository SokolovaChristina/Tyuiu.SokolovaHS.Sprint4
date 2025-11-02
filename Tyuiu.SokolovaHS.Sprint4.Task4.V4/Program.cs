using System;
using Tyuiu.SokolovaHS.Sprint4.Task4.V4.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 3 до 9.              *");
            Console.WriteLine("* Заменить четные элементы массива на 1.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Ввод данных с клавиатуры
            int[,] array = new int[5, 5];
            Console.WriteLine("Введите 25 целых чисел в диапазоне от 3 до 9:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int number) && number >= 3 && number <= 9)
                        {
                            array[i, j] = number;
                            break;
                        }
                        else
                        {
                            Console.Write("Ошибка! Введите число от 3 до 9: ");
                        }
                    }
                }
            }

            // Вывод исходного массива
            Console.WriteLine();
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Замена четных элементов на 1 с использованием библиотеки
            DataService ds = new DataService();
            int[,] resultArray = ds.Calculate(array);

            Console.WriteLine("Массив после замены четных элементов на 1:");
            PrintArray(resultArray);

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

        static void PrintChangesStatistics(int[,] original, int[,] modified)
        {
            int rows = original.GetLength(0);
            int columns = original.GetLength(1);
            int changedCount = 0;
            int unchangedCount = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
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

            Console.WriteLine($"Изменено элементов: {changedCount}");
            Console.WriteLine($"Неизмененных элементов: {unchangedCount}");
            Console.WriteLine($"Всего элементов: {original.Length}");
        }
    }
}