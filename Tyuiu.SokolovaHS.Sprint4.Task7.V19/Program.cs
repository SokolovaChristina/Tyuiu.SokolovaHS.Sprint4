using System;
using Tyuiu.SokolovaHS.Sprint4.Task7.V19.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"90817264\". Преобразуйте ее в        *");
            Console.WriteLine("* матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 4;
            int m = 2;
            string value = "90817264";

            Console.WriteLine($"Размер матрицы: {n} x {m}");
            Console.WriteLine($"Строка: {value}");

            // Вывод матрицы
            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("    ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[i * m + j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(n, m, value);

            Console.WriteLine($"Количество нечетных чисел в матрице: {result}");

            Console.ReadKey();
        }
    }
}