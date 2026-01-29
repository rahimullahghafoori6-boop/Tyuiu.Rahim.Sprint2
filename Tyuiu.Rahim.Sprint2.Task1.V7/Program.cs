using System;
using Tyuiu.Rahim.Sprint2.Task1.V7.Lib;

namespace Tyuiu.Rahim.Sprint2.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рахимов М.С. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Рахимов М.С. | СМАРТб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=) и       *");
            Console.WriteLine("* логических операций (!, &, ||, &&, !, ^), которая вернет логическую     *");
            Console.WriteLine("* последовательность (True, False, True, False, True, False),             *");
            Console.WriteLine("* при a = 119, b = 196, c = 134, d = 327                                  *");
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
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Результаты логических операций:"); 

            // Выводим подробную информацию о каждой операции
            string[] operations = {
                "(a < b) && (c < d)",
                "(a == b) || (c > d)",
                "!(a > b) && !(c == d)",
                "(a != b) ^ (c <= d)",
                "(a >= b) || (c != d) && (a < d)",
                "(a > c) && (b < d) || (a + b) == (c + d)"
            };

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Операция {i + 1}: {operations[i]} = {res[i]}");
            }

            Console.WriteLine("\nИтоговая последовательность: ");
            Console.WriteLine($"({string.Join(", ", res)})");

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* ПРОВЕРКА КАЖДОЙ ОПЕРАЦИИ:                                               *");
            Console.WriteLine("***************************************************************************");

            // Проверка вычислений вручную
            Console.WriteLine($"1. (119 < 196) && (134 < 327) = {119 < 196} && {134 < 327} = {res[0]}");
            Console.WriteLine($"2. (119 == 196) || (134 > 327) = {119 == 196} || {134 > 327} = {res[1]}");
            Console.WriteLine($"3. !(119 > 196) && !(134 == 327) = !{119 > 196} && !{134 == 327} = {res[2]}");
            Console.WriteLine($"4. (119 != 196) ^ (134 <= 327) = {119 != 196} ^ {134 <= 327} = {res[3]}");
            Console.WriteLine($"5. (119 >= 196) || (134 != 327) && (119 < 327) = {119 >= 196} || {134 != 327} && {119 < 327} = {res[4]}");
            Console.WriteLine($"6. (119 > 134) && (196 < 327) || (315 == 461) = {119 > 134} && {196 < 327} || {315 == 461} = {res[5]}");

            Console.ReadKey();
        }
    }
}