using System;
using Tyuiu.SokolovaHS.Sprint4.Task2.V25.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов                     *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от 3 до 9.                *");
            Console.WriteLine("* Подсчитать произведение четных элементов массива.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Создание и заполнение массива случайными числами
            Random random = new Random();
            int[] array = new int[11];

            Console.WriteLine("Массив из 11 элементов (диапазон 3-9):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(3, 10); // от 3 до 9 включительно
            }

            // Вывод массива
            Console.Write("Массив: ");
            PrintArray(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Подсчет произведения четных элементов с использованием библиотеки
            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine($"Произведение четных элементов массива: {result}");
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            Console.Write("{ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");
        }

        static string GetEvenElementsString(int[] array)
        {
            System.Collections.Generic.List<int> evenElements = new System.Collections.Generic.List<int>();
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenElements.Add(num);
                }
            }
            return evenElements.Count > 0 ? "{ " + string.Join(", ", evenElements) + " }" : "четных элементов нет";
        }

        static string GetCalculationString(int[] array)
        {
            System.Collections.Generic.List<string> calculations = new System.Collections.Generic.List<string>();
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    calculations.Add(num.ToString());
                }
            }
            return calculations.Count > 0 ? string.Join(" × ", calculations) : "0";
        }
    }
}