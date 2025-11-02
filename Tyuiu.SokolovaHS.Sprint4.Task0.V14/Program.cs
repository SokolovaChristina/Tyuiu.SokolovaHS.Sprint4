using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaHS.Sprint4.Task0.V14.Lib;

namespace Tyuiu.SokolovaHS.Sprint2.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы(статический ввод)                              *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Исходный массив по заданию
            int[] array = new int[] { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

            // Вывод массива
            Console.WriteLine("Массив: { " + string.Join(", ", array) + " }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создание объекта DataService и вызов метода
            DataService ds = new DataService();
            int result = ds.GetSumOddArrEl(array);

            Console.WriteLine("Сумма нечетных элементов массива: " + result);

            // Дополнительная информация для наглядности
            Console.WriteLine();
            Console.WriteLine("Нечетные элементы: " + GetOddElementsString(array));
            Console.WriteLine("Вычисление: " + GetCalculationString(array) + " = " + result);

            Console.ReadLine();
        }

        // Вспомогательный метод для вывода нечетных элементов
        static string GetOddElementsString(int[] array)
        {
            List<int> oddElements = new List<int>();
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    oddElements.Add(num);
                }
            }
            return "{ " + string.Join(", ", oddElements) + " }";
        }

        // Вспомогательный метод для вывода вычислений
        static string GetCalculationString(int[] array)
        {
            List<string> calculations = new List<string>();
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    calculations.Add(num.ToString());
                }
            }
            return string.Join(" + ", calculations);
        }
    }
}