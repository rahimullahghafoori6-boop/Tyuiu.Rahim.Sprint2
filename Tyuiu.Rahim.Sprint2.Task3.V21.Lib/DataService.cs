using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Rahim.Sprint2.Task3.V21.Lib
{
    public class DataService:ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                // روش عددی پایدارتر
                y = Math.Exp(x * Math.Log(x + 9)) / (x - 1);
            }
            else if (x == 0)
            {
                y = (0 + 10) / (0 - Math.Sin(0) + 12); // 10/12
            }
            else if (x > -25 && x < 2)
            {
                y = Math.Exp(x * Math.Log(1 + 1 / (x * x)));
            }
            else if (x < -25)
            {
                y = 11 * x - (1 / x);
            }
            else
            {
                throw new ArgumentException("Неверное значение X");
            }

            return Math.Round(y, 3);
        }
    }
}