using System;
using Tyuiu.SokolovaHS.Sprint4.Task6.V4.Lib;

namespace Tyuiu.SokolovaHS.Sprint4.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Соколова Х. С. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Соколова Христина Сергеевна | ПКТБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Москва\", \"Санкт Петербург\",           *");
            Console.WriteLine("* \"Новосибирск\", \"Екатеринбург\", \"Нижний Новгород\", \"Казахстан\",  *");
            Console.WriteLine("* \"Самара\"], используя класс Array, выведите элементы массива, длина    *");
            Console.WriteLine("* которых меньше 7 символов.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] cities = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"[{i}] = {cities[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string[] result = ds.Calculate(cities);

            Console.WriteLine("Элементы массива, длина которых меньше 7 символов:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"[{i}] = {result[i]}");
            }

            Console.ReadKey();
        }
    }
}