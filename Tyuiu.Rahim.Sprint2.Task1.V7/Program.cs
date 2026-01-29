using System;
using Tyuiu.Rahim.Sprint2.Task0.V7.Lib;

namespace Tyuiu.Rahim.Sprint2.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рахимов М.С. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Рахимов М.С. | СМАРТб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
            Console.WriteLine("* (True, False, True, True, True, False), при x = 103, y = 475            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 103;
            int y = 475;
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool[] res = ds.GetCompareOperations(x, y);

            Console.WriteLine("Результат сравнений:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Операция {i + 1}: {res[i]}");
            }

            Console.WriteLine("Последовательность: " + string.Join(", ", res));

            Console.ReadKey();
        }
    }
}