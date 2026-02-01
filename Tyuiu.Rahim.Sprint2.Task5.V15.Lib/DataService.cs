using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task5.V15.Lib
{
    public class DataService:ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            // Проверка диапазона
            if (k < 1 || k > 365)
            {
                throw new ArgumentException("День должен быть в диапазоне от 1 до 365");
            }

            // 1 января - понедельник (день недели 1)
            // Находим остаток от деления
            int dayOfWeek = (k - 1) % 7 + 1;

            string result;
            switch (dayOfWeek)
            {
                case 1:
                    result = "Понедельник";
                    break;
                case 2:
                    result = "Вторник";
                    break;
                case 3:
                    result = "Среда";
                    break;
                case 4:
                    result = "Четверг";
                    break;
                case 5:
                    result = "Пятница";
                    break;
                case 6:
                    result = "Суббота";
                    break;
                case 7:
                    result = "Воскресенье";
                    break;
                default:
                    result = "Ошибка";
                    break;
            }

            return result;
        }
    }
}