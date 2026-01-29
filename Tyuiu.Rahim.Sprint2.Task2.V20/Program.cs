using System;
using Tyuiu.Rahim.Sprint2.Task2.V20.Lib;

namespace Tyuiu.Rahim.Sprint2.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рахим И. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Рахим И. | ИИПБ-23-1                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной     *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}