using System;
using Tyuiu.Rahim.Sprint2.Task1.V1.Lib;

namespace Tyuiu.Rahim.Sprint2.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рахим И. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Рахим И. | ИИПБ-23-1                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
            Console.WriteLine("* которая вернет логическую последовательность:                           *");
            Console.WriteLine("* (True, False, True, False, True, False)                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool[] results = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Логическая последовательность (массив):");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"Результат {i + 1} = {results[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("В виде кортежа:");
            Console.WriteLine($"({results[0]}, {results[1]}, {results[2]}, {results[3]}, {results[4]}, {results[5]})");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Задание выполнено успешно!                                                ");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}