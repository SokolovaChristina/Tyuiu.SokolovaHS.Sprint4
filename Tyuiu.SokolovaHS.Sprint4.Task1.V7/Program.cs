using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaHS.Sprint4.Task1.V7.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task1.V7;
    class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов                     *");
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 8.              *");
        Console.WriteLine("* Подсчитать сумму четных элементов массива.                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        // Ввод данных с клавиатуры
        int[] array = new int[11];
        Console.WriteLine("Введите 11 целых чисел в диапазоне от 1 до 8:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 8)
                {
                    array[i] = number;
                    break;
                }
                else
                {
                    Console.Write("Ошибка! Введите число от 1 до 8: ");
                }
            }
        }

        // Вывод введенного массива
        Console.WriteLine();
        Console.Write("Введенный массив: ");
        PrintArray(array);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Подсчет суммы четных элементов с использованием библиотеки
        DataService ds = new DataService();
        int sum = ds.Calculate(array);

        Console.WriteLine($"Сумма четных элементов массива: {sum}");

        // Дополнительная информация
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Четные элементы: " + GetEvenElementsString(array));
        Console.WriteLine("Вычисление: " + GetCalculationString(array) + " = " + sum);

        Console.WriteLine("***************************************************************************");
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
        List<int> evenElements = new List<int>();
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                evenElements.Add(num);
            }
        }
        return "{ " + string.Join(", ", evenElements) + " }";
    }

    static string GetCalculationString(int[] array)
    {
        List<string> calculations = new List<string>();
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                calculations.Add(num.ToString());
            }
        }
        return string.Join(" + ", calculations);
    }
}  
