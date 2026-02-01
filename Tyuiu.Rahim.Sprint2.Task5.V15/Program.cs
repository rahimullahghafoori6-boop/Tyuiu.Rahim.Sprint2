using System;
using Tyuiu.Rahim.Sprint2.Task5.V15.Lib;

namespace Tyuiu.Rahim.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рахим И. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Рахим И. | ИИПБ-23-1                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 < k <= 365). Определить, каким днем недели        *");
            Console.WriteLine("* (понедельником, вторником, ..., субботой или воскресеньем) является     *");
            Console.WriteLine("* k-й день не високосного года, в котором 1 января понедельник.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер дня года (от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            try
            {
                string res = ds.FindDayName(k);
                Console.WriteLine($"{k}-й день года: {res}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ошибка! {e.Message}");
            }

            Console.ReadKey();
        }
    }
}